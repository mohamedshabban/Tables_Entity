using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Data
{
    public class TBL134
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Default)]
        public Guid CardGuide { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(255)]
        public string CardName { get; set; }

        [MaxLength(255)]
        public string LatinName { get; set; }

        [Required]
        public bool AffectItemsTax { get; set; } = false;

        [Required]
        public bool AffectBillTax { get; set; } = false;

        [Required]
        public double BillTaxRatio { get; set; } = 0.0;

        [Required]
        public bool CheckConditions { get; set; } = false;

        [Required]
        public int LocalTypeID { get; set; } = 0;

        [Required]
        public int IntValue01 { get; set; } = 0;
    }

}
