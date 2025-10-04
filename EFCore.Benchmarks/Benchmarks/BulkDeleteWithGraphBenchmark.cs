using BenchmarkDotNet.Attributes;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Benchmarks
{
    [BenchmarkCategory("BulkDeleteWithGraphBenchmark")]
    public class BulkDeleteWithGraphBenchmark : ProgramBenchmarks
    {
        [IterationSetup]
        public void IterationSetup()
        {
            Context = new TestDbContext(ProviderKind);
            Context.EnsureSetup();

            TestEntities = BenchmarkHelper.GenerateTestEntitiesWithGraph(EntityCount, IncludeGraphChildCount);

            // Seed the table with entities that will be deleted during the benchmark
            Context.BulkInsert(TestEntities, options => { options.IncludeGraph = true; });
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
            Context.TestEntities.RemoveRange(TestEntities);
            Context.SaveChanges();
        }

        [Benchmark]
        public void BulkDelete()
        {
            Context.BulkDelete(TestEntities, options => { options.IncludeGraph = true; });
        }
    }
}
