using BenchmarkDotNet.Attributes;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Benchmarks
{
    [BenchmarkCategory("BulkSaveChangesBenchmark")]
    public class BulkSaveChangesBenchmark : ProgramBenchmarks
    {
        [IterationSetup]
        public void IterationSetup()
        {
            Context = new TestDbContext(ProviderKind);
            Context.EnsureSetup();

            // First half: Inserted now so they will be updated
            TestEntities = BenchmarkHelper.GenerateTestEntities(EntityCount / 2);
            Context.BulkInsert(TestEntities);
            Context.TestEntities.UpdateRange(TestEntities);

            // Second half: Added to the list so they will be inserted
            Context.TestEntities.AddRange(BenchmarkHelper.GenerateTestEntities(EntityCount / 2));
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
            Context.SaveChanges();
        }

        [Benchmark]
        public void BulkSaveChanges()
        {
            Context.BulkSaveChanges();
        }
    }
}
