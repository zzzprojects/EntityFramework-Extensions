using Microsoft.Extensions.Configuration;

namespace EFCore.Benchmarks
{
    public static class My
    {
        private static readonly IConfigurationRoot _configuration;

        static My()
        {
            _configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
        }

        public static string SqlServer => _configuration.GetConnectionString("SqlServer")!;
        public static string SQLite => _configuration.GetConnectionString("SQLite")!;
        public static string MariaDB => _configuration.GetConnectionString("MariaDB")!;
        public static string MySQL => _configuration.GetConnectionString("MySQL")!;
        public static string PostgreSQL => _configuration.GetConnectionString("PostgreSQL")!;
        public static string Oracle => _configuration.GetConnectionString("Oracle")!;
    }
}
