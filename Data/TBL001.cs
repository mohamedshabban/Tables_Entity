using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    [Table("TBL001", Schema = "dbo")]
    public class TBL001
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public Guid CardGuide { get; set; }

        [Required]
        [MaxLength(255)]
        public string CurrencyName { get; set; }

        [MaxLength(255)]
        public string LatinName { get; set; }

        [Required]
        public byte Security { get; set; }

        [Required]
        public double Rate { get; set; }

        [MaxLength(255)]
        public string CurrencyShortcut { get; set; }

        [MaxLength(255)]
        public string CurrencyPartName { get; set; }

        [MaxLength(255)]
        public string PartLatinName { get; set; }

        [Required]
        public double Partity { get; set; }
    }
}
