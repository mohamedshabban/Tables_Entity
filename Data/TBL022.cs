using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    [Table("TBL022", Schema = "dbo")]
    public class TBL022
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public Guid CardGuide { get; set; }

        [Required]
        public Guid MainGuide { get; set; }

        [Required]
        public Guid StoreGuide { get; set; }

        [Required]
        public DateTime BillDate { get; set; }

        public DateTime? DateValue01 { get; set; }

        [Required]
        public short PayMethod { get; set; }

        [Required]
        public bool LockRelations { get; set; }

        public Guid? TaxMethod { get; set; }

        [Required]
        public DateTime DoneIn { get; set; }

        [Required]
        public DateTime InsertedIn { get; set; }

        [Required]
        public Guid CurrencyGuide { get; set; }
        // Check constraint
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "BillNumber must be greater than 0.")]
        public int BillNumber { get; set; }

        [Required]
        public int BillNumber2 { get; set; }

        [Required]
        public int OrderNumber { get; set; }

        [Required]
        public double Rate { get; set; }

        [Required]
        public double Discount { get; set; }

        [Required]
        public double LocalAdministrativeTax { get; set; }

        [Required]
        public double TaxValue { get; set; }

        [Required]
        public double DownPayment { get; set; }

        [MaxLength(255)]
        public string DownPaymentNotes { get; set; }

        [Required]
        public double ChangeValue { get; set; }

        [MaxLength(255)]
        public string Notes { get; set; }

        public Guid? AgentGuide { get; set; }

        public Guid? MainBillGuide { get; set; }

        public Guid? POSGuide { get; set; }

        public Guid? PostToAccount { get; set; }

        public Guid? ProductsAccount { get; set; }

        public Guid? CommissionAccount { get; set; }

        public Guid? CreditCard { get; set; }

        [Required]
        public double Paid { get; set; }

        [Required]
        public byte Security { get; set; }

        [MaxLength(255)]
        public string CustomerName { get; set; }

        [Required]
        public byte Posted { get; set; }

        [Column(TypeName = "image")]
        public byte[] CardImage { get; set; }

        public Guid? ContraGuide { get; set; }

        public Guid? ContraStore { get; set; }

        public Guid? CashAccount { get; set; }

        public DateTime? ReturnDate { get; set; }

        public bool? Returned { get; set; }

        public Guid? CostCenter { get; set; }

        [MaxLength(255)]
        public string BillNotes2 { get; set; }

        [MaxLength(255)]
        public string BillNotes3 { get; set; }

        [MaxLength(255)]
        public string BillNotes4 { get; set; }

        [MaxLength(255)]
        public string BillNotes5 { get; set; }

        public Guid? RelatedArchive { get; set; }

        public int? GeneratedBill { get; set; }

        public int? IntValue01 { get; set; }

        public Guid? Project { get; set; }

        public Guid? Branch { get; set; }

        public Guid? Category01 { get; set; }

        public Guid? Category02 { get; set; }

        public Guid? CurrentStage { get; set; }

        public Guid? CalculatingField { get; set; }

        [Required]
        public double RoundValue { get; set; }

        public Guid? SourceBill { get; set; }

        public Guid? ByUser { get; set; }

        public Guid? ByGroup { get; set; }

        public int? CheckID01 { get; set; }

        public int? PrintCount { get; set; }

        [MaxLength]
        public string APIReply { get; set; }

        [MaxLength]
        public string APIReplyText { get; set; }

        // Navigation properties for foreign keys
        [ForeignKey("CurrencyGuide")]
        public virtual TBL001 Currency { get; set; }

        [ForeignKey("PostToAccount")]
        public virtual TBL004 PostToAccountNavigation { get; set; }

        [ForeignKey("CommissionAccount")]
        public virtual TBL004 CommissionAccountNavigation { get; set; }

        [ForeignKey("ProductsAccount")]
        public virtual TBL004 ProductsAccountNavigation { get; set; }

        [ForeignKey("CashAccount")]
        public virtual TBL004 CashAccountNavigation { get; set; }

        [ForeignKey("CostCenter")]
        public virtual TBL005 CostCenterNavigation { get; set; }

        [ForeignKey("StoreGuide")]
        public virtual TBL008 StoreGuideNavigation { get; set; }

        [ForeignKey("ContraStore")]
        public virtual TBL008 ContraStoreNavigation { get; set; }

        [ForeignKey("ByUser")]
        public virtual TBL013 ByUserNavigation { get; set; }

        [ForeignKey("AgentGuide")]
        public virtual TBL016 AgentGuideNavigation { get; set; }

        [ForeignKey("PayMethod")]
        public virtual TBL019 PayMethodNavigation { get; set; }

        [ForeignKey("MainGuide")]
        public virtual TBL020 MainGuideNavigation { get; set; }

        [ForeignKey("POSGuide")]
        public virtual TBL020 POSGuideNavigation { get; set; }

        [ForeignKey("SourceBill")]
        public virtual TBL022 SourceBillNavigation { get; set; }

        [ForeignKey("CreditCard")]
        public virtual TBL025 CreditCardNavigation { get; set; }

        [ForeignKey("MainBillGuide")]
        public virtual TBL027 MainBillGuideNavigation { get; set; }

        [ForeignKey("ByGroup")]
        public virtual TBL042 ByGroupNavigation { get; set; }

        [ForeignKey("Project")]
        public virtual TBL049 ProjectNavigation { get; set; }

        [ForeignKey("Branch")]
        public virtual TBL050 BranchNavigation { get; set; }

        [ForeignKey("RelatedArchive")]
        public virtual TBL085 RelatedArchiveNavigation { get; set; }

        [ForeignKey("CurrentStage")]
        public virtual TBL107 CurrentStageNavigation { get; set; }

        [ForeignKey("TaxMethod")]
        public virtual TBL134 TaxMethodNavigation { get; set; }
    }
}
