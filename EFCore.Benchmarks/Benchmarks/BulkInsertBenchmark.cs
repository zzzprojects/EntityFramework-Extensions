using BenchmarkDotNet.Attributes;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Benchmarks
{
    [BenchmarkCategory("BulkInsertBenchmark")]
    public class BulkInsertBenchmark : ProgramBenchmarks
    {
        [IterationSetup]
        public void IterationSetup()
        {
            Context = new TestDbContext(ProviderKind);
            Context.EnsureSetup();

            TestEntities = BenchmarkHelper.GenerateTestEntities(EntityCount);
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
            Context.TestEntities.AddRange(TestEntities);
            Context.SaveChanges();
        }

        [Benchmark]
        public void BulkInsert()
        {
            Context.BulkInsert(TestEntities);
        }

        [Benchmark]
        public void BulkInsert_NoOutput()
        {
            Context.BulkInsert(TestEntities, options => options.AutoMapOutputDirection = false);
        }

        [Benchmark]
        public void BulkInsertOptimized()
        {
            Context.BulkInsertOptimized(TestEntities);
        }
    }
}
