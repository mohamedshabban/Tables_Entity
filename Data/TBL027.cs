using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    [Table("TBL027", Schema = "dbo")]
    public class TBL027
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Default)]
        public Guid CardGuide { get; set; } = Guid.NewGuid();

        [Required]
        public int CardNumber { get; set; }

        [Required]
        public DateTime DoneIn { get; set; } = DateTime.Now;

        [Required]
        public int TypeID { get; set; } = 0;

        [Required]
        public DateTime InsertedIn { get; set; } = DateTime.Now;

        public Guid? CurrencyGuide1 { get; set; }

        public Guid? CurrencyGuide2 { get; set; }

        public Guid? RelatedBill1 { get; set; }

        public Guid? RelatedBill2 { get; set; }

        public Guid? MainBillGuide { get; set; }

        [Required]
        public double Rate1 { get; set; } = 0;

        [Required]
        public double Rate2 { get; set; } = 0;

        public Guid? CreditCard { get; set; }

        public Guid? ManufacturerModel { get; set; }

        public Guid? MainTransaction { get; set; }

        [Required]
        public short PayMethod1 { get; set; } = 1;

        [Required]
        public Guid StoreGuide1 { get; set; }

        public Guid? StoreGuide2 { get; set; }

        public Guid? AgentGuide1 { get; set; }

        public Guid? AgentGuide2 { get; set; }

        public Guid? AccountA1 { get; set; }

        public Guid? AccountA2 { get; set; }

        public Guid? AccountB1 { get; set; }

        public Guid? AccountB2 { get; set; }

        public Guid? CostCenter1 { get; set; }

        public Guid? CostCenter2 { get; set; }

        public Guid? Project1 { get; set; }

        public Guid? Project2 { get; set; }

        public Guid? Branch1 { get; set; }

        public Guid? Branch2 { get; set; }

        public Guid? Category01 { get; set; }

        public Guid? Category02 { get; set; }

        [Required]
        public Guid MainGuide { get; set; }

        public DateTime? InDate { get; set; }

        public DateTime? InDate2 { get; set; }

        public DateTime? InDate3 { get; set; }

        public DateTime? InDate4 { get; set; }

        [MaxLength(255)]
        public string Customer { get; set; }

        [MaxLength(255)]
        public string CustomerName { get; set; }

        [Required]
        public byte Security { get; set; } = 1;

        [Required]
        public double TaxValue { get; set; } = 0;

        [MaxLength(255)]
        public string BuildBillNotes1 { get; set; }

        [MaxLength(255)]
        public string BuildBillNotes2 { get; set; }

        [MaxLength(255)]
        public string BuildBillNotes3 { get; set; }

        [MaxLength(255)]
        public string BuildBillNotes4 { get; set; }

        [MaxLength(255)]
        public string BuildBillNotes5 { get; set; }

        [MaxLength(255)]
        public string BuildBillNotes6 { get; set; }

        [Required]
        public bool Ready { get; set; }

        [Required]
        public double TimeLong { get; set; }

        [Required]
        public double CostLimit { get; set; }

        [MaxLength(255)]
        public string SentTo { get; set; }

        [Required]
        public double Cost { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public bool Returned { get; set; }

        [Required]
        public bool Posted { get; set; }

        [Required]
        public bool Posted1 { get; set; }

        [Required]
        public bool Posted2 { get; set; }

        [Required]
        public int IntValue01 { get; set; } = 1;

        [Required]
        public int IntValue02 { get; set; } = 1;

        [Required]
        public double Number01 { get; set; } = 1;

        [Required]
        public double Number02 { get; set; } = 1;

        [Column(TypeName = "image")]
        public byte[] CardImage { get; set; }

        [Required]
        public double DownPayment1 { get; set; }

        [Required]
        public double ChangeValue { get; set; }

        [MaxLength(255)]
        public string Receiver { get; set; }

        [Required]
        public bool Delivered { get; set; }

        [Required]
        public bool WithAttachment { get; set; }

        public Guid? CurrentStage { get; set; }

        [MaxLength(255)]
        public string Barcode { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public Guid? ByUser { get; set; }

        public Guid? ByGroup { get; set; }

        [ForeignKey("CurrencyGuide1")]
        public TBL001 Currency1 { get; set; }

        [ForeignKey("CurrencyGuide2")]
        public TBL001 Currency2 { get; set; }

        [ForeignKey("AccountA1")]
        public TBL004 AccountA1Entity { get; set; }

        [ForeignKey("AccountA2")]
        public TBL004 AccountA2Entity { get; set; }

        [ForeignKey("AccountB1")]
        public TBL004 AccountB1Entity { get; set; }

        [ForeignKey("AccountB2")]
        public TBL004 AccountB2Entity { get; set; }

        [ForeignKey("CostCenter1")]
        public TBL005 CostCenter1Entity { get; set; }

        [ForeignKey("CostCenter2")]
        public TBL005 CostCenter2Entity { get; set; }

        [ForeignKey("StoreGuide1")]
        public TBL008 StoreGuide1Entity { get; set; }

        [ForeignKey("StoreGuide2")]
        public TBL008 StoreGuide2Entity { get; set; }

        [ForeignKey("ByUser")]
        public TBL013 ByUserEntity { get; set; }

        [ForeignKey("AgentGuide1")]
        public TBL016 AgentGuide1Entity { get; set; }

        [ForeignKey("AgentGuide2")]
        public TBL016 AgentGuide2Entity { get; set; }

        [ForeignKey("PayMethod1")]
        public TBL019 PayMethod { get; set; }

        [ForeignKey("RelatedBill1")]
        public TBL022 RelatedBill1Entity { get; set; }

        [ForeignKey("RelatedBill2")]
        public TBL022 RelatedBill2Entity { get; set; }

        [ForeignKey("MainBillGuide")]
        public TBL022 MainBillGuideEntity { get; set; }

        [ForeignKey("MainGuide")]
        public TBL026 MainGuideEntity { get; set; }

        [ForeignKey("MainTransaction")]
        public TBL027 MainTransactionEntity { get; set; }

        [ForeignKey("ByGroup")]
        public TBL042 ByGroupEntity { get; set; }

        [ForeignKey("Project1")]
        public TBL049 Project1Entity { get; set; }

        [ForeignKey("Project2")]
        public TBL049 Project2Entity { get; set; }

        [ForeignKey("Branch1")]
        public TBL050 Branch1Entity { get; set; }

        [ForeignKey("Branch2")]
        public TBL050 Branch2Entity { get; set; }

        [ForeignKey("ManufacturerModel")]
        public TBL078 ManufacturerModelEntity { get; set; }

        [ForeignKey("Category01")]
        public TBL081 Category01Entity { get; set; }

        [ForeignKey("Category02")]
        public TBL081 Category02Entity { get; set; }

        [ForeignKey("CurrentStage")]
        public TBL107 CurrentStageEntity { get; set; }
    }

}
