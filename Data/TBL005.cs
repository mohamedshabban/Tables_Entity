using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    [Table("TBL005", Schema = "dbo")]
    public class TBL005
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public Guid CardGuide { get; set; }

        [Required]
        public bool NotActive { get; set; }

        [Required]
        [MaxLength(255)]
        public string CardCode { get; set; }

        [Required]
        public byte Security { get; set; }

        [Required]
        [MaxLength(255)]
        public string CostCenter { get; set; }

        [MaxLength(255)]
        public string LatinName { get; set; }

        [Required]
        public byte CardType { get; set; }

        public Guid? DefaultAccount { get; set; }

        public Guid? DefaultAccount2 { get; set; }

        public Guid? DefaultAccount3 { get; set; }

        public Guid? MainCostCenter { get; set; }

        public double? DefaultValue { get; set; }

        [Required]
        public int IntValue { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        [Column(TypeName = "image")]
        public byte[] CardImage { get; set; }

        [MaxLength(255)]
        public string CostCenterNotes2 { get; set; }

        [MaxLength(255)]
        public string CostCenterNotes3 { get; set; }

        [MaxLength(255)]
        public string CostCenterNotes4 { get; set; }

        [MaxLength(255)]
        public string CostCenterNotes5 { get; set; }

        [MaxLength(255)]
        public string CostCenterNotes6 { get; set; }

        [MaxLength(255)]
        public string CostCenterNotes7 { get; set; }

        [MaxLength(255)]
        public string CostCenterNotes8 { get; set; }

        [MaxLength(255)]
        public string CostCenterNotes9 { get; set; }

        [Required]
        public bool UsedInHR { get; set; }

        public Guid? ByUser { get; set; }

        public Guid? ByGroup { get; set; }

        // Navigation properties for foreign keys
        [ForeignKey("DefaultAccount")]
        public virtual TBL004 DefaultAccountNavigation { get; set; }

        [ForeignKey("DefaultAccount2")]
        public virtual TBL004 DefaultAccount2Navigation { get; set; }

        [ForeignKey("DefaultAccount3")]
        public virtual TBL004 DefaultAccount3Navigation { get; set; }

        [ForeignKey("MainCostCenter")]
        public virtual TBL005 MainCostCenterNavigation { get; set; }

        [ForeignKey("ByUser")]
        public virtual TBL013 ByUserNavigation { get; set; }

        [ForeignKey("ByGroup")]
        public virtual TBL042 ByGroupNavigation { get; set; }
    }
}
