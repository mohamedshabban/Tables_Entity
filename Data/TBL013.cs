using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    [Table("TBL013", Schema = "dbo")]
    public class TBL013
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public Guid UsGuide { get; set; }

        [MaxLength(255)]
        public string CardCode { get; set; }

        [Required]
        public bool NotActive { get; set; }

        [Required]
        [MaxLength(255)]
        public string UserName { get; set; }

        [MaxLength(50)]
        public string Password { get; set; }

        [Column(TypeName = "ntext")]
        public string Informations { get; set; }

        [Required]
        public byte Security { get; set; }

        [Required]
        public short UserLanguage { get; set; }

        public Guid? POSGuide { get; set; }

        [Required]
        public DateTime BuiltIn { get; set; }

        [Required]
        public bool ShowInDropDown { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        public int? UserColor { get; set; }

        public Guid? RelatedAgent { get; set; }

        public Guid? OptionGuide { get; set; }

        public Guid? CostCenterGuide { get; set; }

        public Guid? ProjectGuide { get; set; }

        public Guid? BranchGuide { get; set; }

        public Guid? StoreGuide { get; set; }

        [Column(TypeName = "image")]
        public byte[] CardImage { get; set; }

        // Navigation properties for foreign keys
        [ForeignKey("CostCenterGuide")]
        public virtual TBL005 CostCenterGuideNavigation { get; set; }

        [ForeignKey("StoreGuide")]
        public virtual TBL008 StoreGuideNavigation { get; set; }

        [ForeignKey("RelatedAgent")]
        public virtual TBL016 RelatedAgentNavigation { get; set; }

        [ForeignKey("ProjectGuide")]
        public virtual TBL049 ProjectGuideNavigation { get; set; }

        [ForeignKey("BranchGuide")]
        public virtual TBL050 BranchGuideNavigation { get; set; }

        [ForeignKey("OptionGuide")]
        public virtual TBL122 OptionGuideNavigation { get; set; }
    }
}
