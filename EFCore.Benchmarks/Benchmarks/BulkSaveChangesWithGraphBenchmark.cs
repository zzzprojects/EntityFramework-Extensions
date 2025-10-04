using BenchmarkDotNet.Attributes;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Benchmarks
{
    [BenchmarkCategory("BulkSaveChangesWithGraphBenchmark")]
    public class BulkSaveChangesWithGraphBenchmark : ProgramBenchmarks
    {
        [IterationSetup]
        public void IterationSetup()
        {
            Context = new TestDbContext(ProviderKind);
            Context.EnsureSetup();

            // First half: Inserted now so they will be updated
            TestEntities = BenchmarkHelper.GenerateTestEntitiesWithGraph(EntityCount / 2, IncludeGraphChildCount);
            Context.BulkInsert(TestEntities, options => { options.IncludeGraph = true; });
            Context.TestEntities.UpdateRange(TestEntities);

            // Second half: Added to the list so they will be inserted
            Context.TestEntities.AddRange(BenchmarkHelper.GenerateTestEntitiesWithGraph(EntityCount / 2, IncludeGraphChildCount));
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
