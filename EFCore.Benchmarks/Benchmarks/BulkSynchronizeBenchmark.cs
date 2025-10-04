using BenchmarkDotNet.Attributes;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Benchmarks
{
    [BenchmarkCategory("BulkSynchronizeBenchmark")]
    public class BulkSynchronizeBenchmark : ProgramBenchmarks
    {
        [IterationSetup]
        public void IterationSetup()
        {
            Context = new TestDbContext(ProviderKind);
            Context.EnsureSetup();

            TestEntities = BenchmarkHelper.GenerateTestEntities(EntityCount);

            // Prepare test data so that BulkSynchronize will:
            Context.BulkInsert(TestEntities);

            // - Update half of EntityCount (pre-inserted and kept in the list)
            // - Delete half of EntityCount (pre-inserted but not kept in the list)
            TestEntities = TestEntities.Take(EntityCount / 2).ToList();

            // - Insert half of EntityCount (newly generated and not yet in the database)
            TestEntities.AddRange(BenchmarkHelper.GenerateTestEntities(EntityCount / 2));
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
        public void BulkSynchronize()
        {
            Context.BulkSynchronize(TestEntities);
        }
    }
}
