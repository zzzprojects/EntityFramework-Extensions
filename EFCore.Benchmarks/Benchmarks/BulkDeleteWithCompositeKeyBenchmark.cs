using BenchmarkDotNet.Attributes;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Benchmarks
{
    [BenchmarkCategory("BulkDeleteWithCompositeKeyBenchmark")]
    public class BulkDeleteWithCompositeKeyBenchmark : ProgramBenchmarks
    {
        [IterationSetup]
        public void IterationSetup()
        {
            Context = new TestDbContext(ProviderKind);
            Context.EnsureSetup();

            TestCompositeKeyEntities = BenchmarkHelper.GenerateTestCompositeKeyEntities(EntityCount);

            // Seed the table with entities that will be deleted during the benchmark
            Context.BulkInsert(TestCompositeKeyEntities);
        }

        [IterationCleanup]
        public void IterationCleanup()
        {
			// Remove all entities to reset the table for the next iteration
			if (ProviderKind == TestProviderKind.MariaDB)
			{
				Context.TestCompositeKeyEntities.DeleteFromQuery();
			}
			else
			{
				Context.TestCompositeKeyEntities.ExecuteDelete();
			}

	
        }

        [Benchmark]
        public void SaveChanges()
        {
            Context.TestCompositeKeyEntities.RemoveRange(TestCompositeKeyEntities);
            Context.SaveChanges();
        }

        [Benchmark]
        public void BulkDelete()
        {
            Context.BulkDelete(TestCompositeKeyEntities);
        }
    }
}
