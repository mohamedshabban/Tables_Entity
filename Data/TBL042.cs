using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{

    [Table("TBL042", Schema = "dbo")]

    public class TBL042
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Default)]
        public Guid CardGuide { get; set; } = Guid.NewGuid();

        public Guid? MainGuide { get; set; }

        [Required]
        public bool IsUser { get; set; }

        [Required]
        [MaxLength(255)]
        public string CardName { get; set; }

        [MaxLength(255)]
        public string CardLatinName { get; set; }

        [Required]
        public byte Security { get; set; } = 1;

        [Required]
        public bool JustForPOS { get; set; }

        [Required]
        public bool SeparateGroup { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        [Required]
        public bool CheckAccounts { get; set; }

        [Required]
        public bool CheckCostCenters { get; set; }

        [Required]
        public bool CheckProjects { get; set; }

        [Required]
        public bool CheckBranches { get; set; }

        [Required]
        public bool CheckStores { get; set; }

        [Required]
        public bool CheckGroups { get; set; }

        [Required]
        public bool CheckAgentsGroups { get; set; }

        [Required]
        public bool CheckUsedAccounts { get; set; }

        [Required]
        public bool CheckUsedCostCenters { get; set; }

        [Required]
        public bool CheckUsedProjects { get; set; }

        [Required]
        public bool CheckUsedBranches { get; set; }

        [Required]
        public bool CheckUsedStores { get; set; }

        [Required]
        public bool CheckUsedGroups { get; set; }

        [Required]
        public bool CheckUsedAgentsGroups { get; set; }

        public Guid? CostCenterID { get; set; }

        public Guid? ProjectID { get; set; }

        public Guid? BranchID { get; set; }

        public Guid? StoreID { get; set; }

        public Guid? CashAccountID { get; set; }

        [Required]
        public bool UseCostCenters { get; set; }

        [Required]
        public bool UseProjects { get; set; }

        [Required]
        public bool UseBranches { get; set; }

        [Required]
        public bool UseStores { get; set; }

        [Required]
        public bool UseCashAccount { get; set; }

        [Column(TypeName = "image")]
        public byte[] CardImage { get; set; }

        [Required]
        public int FirstTransactionsNo { get; set; }

        [Required]
        public bool SeparateFinancialReports { get; set; }

        [Required]
        public bool HideSeparatesColumn { get; set; }

        [ForeignKey("CashAccountID")]
        public TBL004 CashAccount { get; set; }

        [ForeignKey("CostCenterID")]
        public TBL005 CostCenter { get; set; }

        [ForeignKey("StoreID")]
        public TBL008 Store { get; set; }

        [ForeignKey("MainGuide")]
        public TBL042 MainGuideEntity { get; set; }

        [ForeignKey("ProjectID")]
        public TBL049 Project { get; set; }

        [ForeignKey("BranchID")]
        public TBL050 Branch { get; set; }
    }

}
