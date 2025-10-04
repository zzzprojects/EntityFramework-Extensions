using BenchmarkDotNet.Attributes;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Benchmarks
{
    [BenchmarkCategory("BulkDeleteBenchmark")]
    public class BulkDeleteBenchmark: ProgramBenchmarks
    {
        [IterationSetup]
        public void IterationSetup()
        {
            Context = new TestDbContext(ProviderKind);
            Context.EnsureSetup();

            TestEntities = BenchmarkHelper.GenerateTestEntities(EntityCount);

            // Seed the table with entities that will be deleted during the benchmark
            Context.BulkInsert(TestEntities);
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
            Context.BulkDelete(TestEntities);
        }
    }
}
