using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{

    [Table("TBL050", Schema = "dbo")]

    public class TBL050
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Default)]
        public Guid CardGuide { get; set; } = Guid.NewGuid();

        [Required]
        public bool NotActive { get; set; }

        [Required]
        [MaxLength(255)]
        public string CardCode { get; set; }

        [Required]
        public byte Security { get; set; } = 1;

        [Required]
        [MaxLength(255)]
        public string BronchName { get; set; }

        [MaxLength(255)]
        public string LatinName { get; set; }

        public Guid? DefaultAccount { get; set; }

        [MaxLength(255)]
        public string BranchNotes2 { get; set; }

        [MaxLength(255)]
        public string BranchNotes3 { get; set; }

        public Guid? MainBronch { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        [Column(TypeName = "image")]
        public byte[] CardImage { get; set; }

        public Guid? ByUser { get; set; }

        public Guid? ByGroup { get; set; }

        [ForeignKey("DefaultAccount")]
        public TBL004 DefaultAccountEntity { get; set; }

        [ForeignKey("ByUser")]
        public TBL013 ByUserEntity { get; set; }

        [ForeignKey("ByGroup")]
        public TBL042 ByGroupEntity { get; set; }

        [ForeignKey("MainBronch")]
        public TBL050 MainBronchEntity { get; set; }
    }

}
