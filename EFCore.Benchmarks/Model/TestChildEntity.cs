using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.Benchmarks
{
    public class TestChildEntity
    {
        // Use "[NotMapped]" to ignore properties if you want to benchmark with less
        [NotMapped]
        public bool IamNotMapped { get; set; }

        public int ID { get; set; }
        public int Col1 { get; set; }
        public int Col2 { get; set; }
        public int Col3 { get; set; }
        public int Col4 { get; set; }
        public int Col5 { get; set; }

        [MaxLength(255)]
        public string? Col6 { get; set; }
        [MaxLength(255)]
        public string? Col7 { get; set; }
        [MaxLength(255)]
        public string? Col8 { get; set; }
        [MaxLength(255)]
        public string? Col9 { get; set; }
        [MaxLength(255)]
        public string? Col10 { get; set; }
    }
}
