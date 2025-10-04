using Microsoft.EntityFrameworkCore;

namespace EFCore.Benchmarks
{
    public class TestDbContext: DbContext
    {
        public TestDbContext(TestProviderKind provider)
        {
            ProviderKind = provider;
        }

        public void EnsureSetup()
        {
            switch (ProviderKind)
            {
                case TestProviderKind.SqlServer:
				case TestProviderKind.PostgreSQL:
				case TestProviderKind.SQLite:
				case TestProviderKind.MySQL:
				case TestProviderKind.MariaDB:
					this.Database.EnsureCreated();
                    break;
				case TestProviderKind.Oracle:
                    try
                    {
						this.Database.EnsureCreated();
					}
                    catch
                    {

                    }
				
					break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(ProviderKind), ProviderKind, "Unsupported provider");
            }
        }

        public TestProviderKind ProviderKind { get; set; }
        public DbSet<TestEntity> TestEntities { get; set; }
        public DbSet<TestChildEntity> TestChildEntities { get; set; }
        public DbSet<TestCompositeKeyEntity> TestCompositeKeyEntities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                switch (ProviderKind)
                {
                    case TestProviderKind.SqlServer:
                        optionsBuilder.UseSqlServer(My.SqlServer);
                        break;

                    case TestProviderKind.SQLite:
                        optionsBuilder.UseSqlite(My.SQLite);
                        break;

                    case TestProviderKind.MariaDB:
                        optionsBuilder.UseMySQL(My.MariaDB);
                        break;

                    case TestProviderKind.MySQL:
                        optionsBuilder.UseMySQL(My.MySQL);
                        break;

                    case TestProviderKind.PostgreSQL:
                        optionsBuilder.UseNpgsql(My.PostgreSQL);
                        break;

                    case TestProviderKind.Oracle:
                        optionsBuilder.UseOracle(My.Oracle);
                        break;

                    default:
                        throw new Exception($"Unknown ProviderKind: {ProviderKind}");
                }
            }
        }
    }
}
