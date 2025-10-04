using BenchmarkDotNet.Attributes;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Benchmarks
{
    [BenchmarkCategory("BulkInsertWithKeepIdentityBenchmark")]
    public class BulkInsertWithKeepIdentityBenchmark : ProgramBenchmarks
    {
        [IterationSetup]
        public void IterationSetup()
        {
            Context = new TestDbContext(ProviderKind);
            Context.EnsureSetup();

            TestEntities = BenchmarkHelper.GenerateTestEntities(EntityCount);

            // Pre-assign sequential IDs to test "keep identity"
            for (int i = 0; i < EntityCount; i++)
            {
                TestEntities[i].ID = i + 1;
            }
        }

        [IterationCleanup]
        public void IterationCleanup()
        {
			// Remove all entities to reset the table for the next iteration
			if (ProviderKind == TestProviderKind.MariaDB)
			{
				Context.TestChildEntities.DeleteFromQuery();
				Context.TestEntities.DeleteFromQuery();
			}
			else
			{
				Context.TestChildEntities.ExecuteDelete();
				Context.TestEntities.ExecuteDelete();
			}
		}

        [Benchmark]
        public void SaveChanges()
        {
            if (ProviderKind == TestProviderKind.SqlServer)
            {
#pragma warning disable EF1002 // Risk of vulnerability to SQL injection.

                var tableName = Context.Model.FindEntityType(typeof(TestEntity)).GetTableName();

                Context.Database.OpenConnection();

                // Turn on IDENTITY_INSERT for your table

                Context.Database.ExecuteSqlRaw($"SET IDENTITY_INSERT [dbo].[{tableName}] ON");

                Context.TestEntities.AddRange(TestEntities);
                Context.SaveChanges();

                // Turn off IDENTITY_INSERT
                Context.Database.ExecuteSqlRaw($"SET IDENTITY_INSERT [dbo].[{tableName}] OFF");

                Context.Database.CloseConnection();

#pragma warning restore EF1002 // Risk of vulnerability to SQL injection.
            }
            else if (ProviderKind == TestProviderKind.PostgreSQL || ProviderKind == TestProviderKind.Oracle || ProviderKind == TestProviderKind.SQLite || ProviderKind == TestProviderKind.MySQL || ProviderKind == TestProviderKind.MariaDB)
            {
				Context.TestEntities.AddRange(TestEntities);
				Context.SaveChanges();
			}
		}

        [Benchmark]
        public void BulkInsert()
        {
            Context.BulkInsert(TestEntities, options => { options.InsertKeepIdentity = true; });
        }
    }
}
