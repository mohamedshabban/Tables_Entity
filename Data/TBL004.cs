using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    [Table("TBL004", Schema = "dbo")]
    public class TBL004
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public Guid CardGuide { get; set; }

        [Required]
        public bool NotActive { get; set; }

        [Required]
        public Guid ClosingAccount { get; set; }

        [Required]
        [MaxLength(255)]
        public string CardCode { get; set; }

        [Required]
        [MaxLength(255)]
        public string AccountName { get; set; }

        public Guid? MainAccount { get; set; }

        public Guid? DefaultCurrency { get; set; }

        public Guid? DefaultCostCenter { get; set; }

        public Guid? DefaultBranch { get; set; }

        public Guid? DefaultProject { get; set; }

        public Guid? Item_ID { get; set; }

        [MaxLength(255)]
        public string LatinName { get; set; }

        [MaxLength(255)]
        public string TaxCode { get; set; }

        [Required]
        public byte Security { get; set; }

        [Required]
        public double MaxDebit { get; set; }

        [Required]
        public double MaxCredit { get; set; }

        [Required]
        public double NotepaperMaxDebit { get; set; }

        [Required]
        public double NotepaperMaxCredit { get; set; }

        [Required]
        public short Caution { get; set; }

        [Required]
        public DateTime BuiltIn { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        [Column(TypeName = "image")]
        public byte[] CardImage { get; set; }

        public Guid? CalculatingField { get; set; }

        public Guid? ByUser { get; set; }

        public Guid? ByGroup { get; set; }

        // Navigation properties for foreign keys
        [ForeignKey("DefaultCurrency")]
        public virtual TBL001 DefaultCurrencyNavigation { get; set; }

        [ForeignKey("ClosingAccount")]
        public virtual TBL002 ClosingAccountNavigation { get; set; }

        [ForeignKey("MainAccount")]
        public virtual TBL004 MainAccountNavigation { get; set; }

        [ForeignKey("DefaultCostCenter")]
        public virtual TBL005 DefaultCostCenterNavigation { get; set; }

        [ForeignKey("ByUser")]
        public virtual TBL013 ByUserNavigation { get; set; }

        [ForeignKey("ByGroup")]
        public virtual TBL042 ByGroupNavigation { get; set; }

        [ForeignKey("DefaultProject")]
        public virtual TBL049 DefaultProjectNavigation { get; set; }

        [ForeignKey("DefaultBranch")]
        public virtual TBL050 DefaultBranchNavigation { get; set; }
    }
}
