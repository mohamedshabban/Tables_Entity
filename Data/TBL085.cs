using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class TBL085
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Default)]
        public Guid CardGuide { get; set; } = Guid.NewGuid();

        [Required]
        public Guid TypeGuide { get; set; }

        public DateTime? CardDate { get; set; }

        public DateTime? CardDate2 { get; set; }

        public DateTime? DateValue01 { get; set; }

        public Guid? RelatedArchive { get; set; }

        public Guid? RelatedArchive2 { get; set; }

        public Guid? RelatedCostCenter { get; set; }

        [Required]
        public byte Security { get; set; } = 1;

        [Required]
        public int CardNumber { get; set; } = 0;

        [Required]
        public float NumberValue01 { get; set; } = 0;

        [Required]
        public int IntValue01 { get; set; } = 0;

        [Required]
        public int IntValue02 { get; set; } = 0;

        [Required]
        public int IntValue03 { get; set; } = 0;

        [MaxLength]
        public string TextValue01 { get; set; }

        [MaxLength]
        public string TextValue02 { get; set; }

        [MaxLength]
        public string TextValue03 { get; set; }

        public Guid? Project { get; set; }

        public Guid? Branch { get; set; }

        public Guid? CostCenter { get; set; }

        public Guid? Store { get; set; }

        public Guid? UserGuide { get; set; }

        [Required]
        public bool BooleanValue01 { get; set; } = false;

        [Required]
        public bool BooleanValue02 { get; set; } = false;

        [Required]
        public bool BooleanValue03 { get; set; } = false;

        [Required]
        public bool BooleanValue04 { get; set; } = false;

        [Required]
        public bool BooleanValue05 { get; set; } = false;

        [Required]
        public bool BooleanValue06 { get; set; } = false;

        [Required]
        public bool BooleanValue07 { get; set; } = false;

        [Required]
        public bool BooleanValue08 { get; set; } = false;

        [MaxLength]
        public string CardName { get; set; }

        [MaxLength]
        public string Notes { get; set; }

        [Column(TypeName = "image")]
        public byte[] CardImage { get; set; }

        public Guid? ByUser { get; set; }

        public Guid? ByGroup { get; set; }

        [ForeignKey("CostCenter")]
        public TBL005 CostCenterEntity { get; set; }

        [ForeignKey("RelatedCostCenter")]
        public TBL005 RelatedCostCenterEntity { get; set; }

        [ForeignKey("Store")]
        public TBL008 StoreEntity { get; set; }

        [ForeignKey("UserGuide")]
        public TBL013 UserGuideEntity { get; set; }

        [ForeignKey("ByGroup")]
        public TBL042 ByGroupEntity { get; set; }

        [ForeignKey("Project")]
        public TBL049 ProjectEntity { get; set; }

        [ForeignKey("Branch")]
        public TBL050 BranchEntity { get; set; }

        [ForeignKey("TypeGuide")]
        public TBL084 TypeGuideEntity { get; set; }

        [ForeignKey("RelatedArchive")]
        public TBL085 RelatedArchiveEntity { get; set; }

        [ForeignKey("RelatedArchive2")]
        public TBL085 RelatedArchive2Entity { get; set; }
    }

}
