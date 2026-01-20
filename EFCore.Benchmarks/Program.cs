using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using Perfolizer.Horology;
using Perfolizer.Metrology;

namespace EFCore.Benchmarks
{
    public class ProgramBenchmarks
    {
        // ─────────────────────────────────────────────────────────────────────────
        // QUICK START (do these in order)
        //  A) Make sure you run in **Release** configuration
        //     - CLI:   dotnet run -c Release
        //     - VS/Rider: Select "Release" (not Debug) before running
        //
        //  B) Set your connection strings in **appsettings.json**
        //     - Keys: ConnectionStrings.SqlServer / .PostgreSQL / .Oracle / .SQLite / .MySQL / .MariaDB
        //     - The DbContext reads them via the static My class (My.SqlServer, etc.)
        //
        //  C) In THIS file:
        //     - Pick provider(s) under "CHOOSE PROVIDER(S)" below.
        //     - Pick entity count(s) under "CHOOSE ENTITY COUNT(S)" below.
        //
        //  D) Select which benchmarks to run by commenting/uncommenting types
        //     in the 'switcher' array further down.
        // ─────────────────────────────────────────────────────────────────────────

        // ─────────────────────────────────────────────────────────────────────────
        // 1) CHOOSE PROVIDER(S)
        // Leave EXACTLY ONE [Params(...)] line uncommented for this field.
        //   - Single provider: [Params(TestProviderKind.SqlServer)]
        //   - Multiple providers: put them in the SAME [Params(...)] line.
        // ─────────────────────────────────────────────────────────────────────────
        [Params(
            TestProviderKind.SqlServer
        //, TestProviderKind.PostgreSQL
        //, TestProviderKind.Oracle
        //, TestProviderKind.SQLite
        //, TestProviderKind.MySQL
        //, TestProviderKind.MariaDB
        )]
        public TestProviderKind ProviderKind;

        // ─────────────────────────────────────────────────────────────────────────
        // 2) CHOOSE ENTITY COUNT(S)
        // Leave EXACTLY ONE [Params(...)] line uncommented for this field.
        //   - Single count: [Params(10)]
        //   - Multiple counts: [Params(10, 1_000, 10_000)]
        // ─────────────────────────────────────────────────────────────────────────
        [Params(
         //,   10
         //, 100
         //, 1_000
         10_000
        //, 100_000
        //, 1_000_000
        )]
        public int EntityCount;

        public TestDbContext? Context;
        public List<TestEntity>? TestEntities;
        public List<TestCompositeKeyEntity>? TestCompositeKeyEntities;
        public int IncludeGraphChildCount = 5;

        static void Main(string[] args)
        {
            // ─────────────────────────────────────────────────────────────────────
            // REMINDERS
            //  - Run in **Release**: dotnet run -c Release
            //  - Connection strings come from **appsettings.json** via My.{Provider}
            // ─────────────────────────────────────────────────────────────────────

            var switcher = new BenchmarkSwitcher(new[]
            {
                // ==== Bulk Delete ====
                //typeof(BulkDeleteBenchmark),
                //typeof(BulkDeleteWithCompositeKeyBenchmark),
                //typeof(BulkDeleteWithGraphBenchmark),

                // ==== Bulk Insert ====
                typeof(BulkInsertBenchmark),
                typeof(BulkInsertWithGraphBenchmark),
                typeof(BulkInsertWithKeepIdentityBenchmark),

                // ==== Bulk Merge ====
                //typeof(BulkMergeBenchmark),
                //typeof(BulkMergeWithGraphBenchmark),

                // ==== Bulk SaveChanges ====
                //typeof(BulkSaveChangesBenchmark),
                //typeof(BulkSaveChangesWithGraphBenchmark),

                // ==== Bulk Synchronize ====
                //typeof(BulkSynchronizeBenchmark),

                // ==== Bulk Update ====
                //typeof(BulkUpdateBenchmark),
                //typeof(BulkUpdateWithGraphBenchmark),
            });

            var config = ManualConfig
                .Create(DefaultConfig.Instance)
                .WithSummaryStyle(SummaryStyle.Default
                    .WithRatioStyle(RatioStyle.Value)         // keep ratios normal
                    .WithTimeUnit(TimeUnit.Millisecond)       // force ms
                    .WithSizeUnit(SizeUnit.KB)                // allocations in KB
                )
                .AddDiagnoser(MemoryDiagnoser.Default)
                .AddLogicalGroupRules(BenchmarkLogicalGroupRule.ByCategory)
                .WithOrderer(new DefaultOrderer(SummaryOrderPolicy.Default, MethodOrderPolicy.Declared))
                .HideColumns("ProviderKind", "Error", "StdDev", "Median", "Gen0", "Gen1", "Gen2")
                .AddJob(Job.Default
                    .WithIterationCount(25)
                    .WithWarmupCount(1)
                    .WithId("EFE")
                );

            // 🚀 Run all selected benchmarks.
            // ⚠️ Heads-up: full runs can be long — perfect time for coffee.
            switcher.RunAllJoined(config);
        }
    }
}