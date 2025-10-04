using BenchmarkDotNet.Attributes;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Benchmarks
{
    [BenchmarkCategory("BulkMergeWithGraphBenchmark")]
    public class BulkMergeWithGraphBenchmark : ProgramBenchmarks
    {
        [IterationSetup]
        public void IterationSetup()
        {
            Context = new TestDbContext(ProviderKind);
            Context.EnsureSetup();

            // First half: Inserted now so they will be updated during BulkMerge
            TestEntities = BenchmarkHelper.GenerateTestEntitiesWithGraph(EntityCount / 2, IncludeGraphChildCount);
            Context.BulkInsert(TestEntities, options => { options.IncludeGraph = true; });

            // Second half: Added to the list so they will be inserted during BulkMerge
            TestEntities.AddRange(BenchmarkHelper.GenerateTestEntitiesWithGraph(EntityCount / 2, IncludeGraphChildCount));
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
            Context.TestEntities.UpdateRange(TestEntities.Where(x => x.ID > 0));
            Context.TestEntities.AddRange(TestEntities.Where(x => x.ID == 0));
            Context.SaveChanges();
        }

        [Benchmark]
        public void BulkMerge()
        {
            Context.BulkMerge(TestEntities, options => { options.IncludeGraph = true; });
        }
    }
}
