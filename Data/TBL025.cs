using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Data
{
    public class TBL025
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Default)]
        public Guid CardGuide { get; set; } = Guid.NewGuid();

        [Required]
        public byte Security { get; set; } = 1;

        [Required]
        [MaxLength(255)]
        public string CardName { get; set; }

        public Guid? CurrencyGuide { get; set; }

        public Guid? AccountID { get; set; }

        public Guid? TaxAccountID { get; set; }

        [MaxLength(255)]
        public string TaxNotes { get; set; }

        [Required]
        public double TaxRatio { get; set; } = 0;

        public Guid? CostCenter { get; set; }

        public Guid? Project { get; set; }

        public Guid? Branch { get; set; }

        [Required]
        public double CommissionRatio { get; set; } = 0.01;

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        public byte? CashPaymentMethod { get; set; }

        [MaxLength(255)]
        public string CashID { get; set; }

        [MaxLength(255)]
        public string CashUser { get; set; }

        [MaxLength(255)]
        public string CashPass { get; set; }

        [Column(TypeName = "image")]
        public byte[] CardImage { get; set; }

        public Guid? ByUser { get; set; }

        public Guid? ByGroup { get; set; }

        [ForeignKey("CurrencyGuide")]
        public TBL001 Currency { get; set; }

        [ForeignKey("AccountID")]
        public TBL004 Account { get; set; }

        [ForeignKey("TaxAccountID")]
        public TBL004 TaxAccount { get; set; }

        [ForeignKey("CostCenter")]
        public TBL005 CostCenterEntity { get; set; }

        [ForeignKey("ByUser")]
        public TBL013 ByUserEntity { get; set; }

        [ForeignKey("ByGroup")]
        public TBL042 ByGroupEntity { get; set; }

        [ForeignKey("Project")]
        public TBL049 ProjectEntity { get; set; }

        [ForeignKey("Branch")]
        public TBL050 BranchEntity { get; set; }
    }

}
