using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class TBL107
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

        public Guid? CostCenter { get; set; }

        public Guid? Project { get; set; }

        public Guid? Branch { get; set; }

        public Guid? Category01 { get; set; }

        public Guid? Category02 { get; set; }

        [MaxLength(255)]
        public string Notes { get; set; }

        [MaxLength(255)]
        public string Notes2 { get; set; }

        [MaxLength(255)]
        public string Notes3 { get; set; }

        [ForeignKey("CostCenter")]
        public TBL005 CostCenterEntity { get; set; }

        [ForeignKey("Project")]
        public TBL049 ProjectEntity { get; set; }

        [ForeignKey("Branch")]
        public TBL050 BranchEntity { get; set; }

        [ForeignKey("Category01")]
        public TBL081 Category01Entity { get; set; }

        [ForeignKey("Category02")]
        public TBL081 Category02Entity { get; set; }
    }

}
