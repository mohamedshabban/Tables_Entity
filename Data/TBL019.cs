using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    [Table("TBL019", Schema = "dbo")]
    public class TBL019
    {
        [Key]
        public short ID { get; set; }

        [Required]
        [MaxLength(255)]
        [Index(IsUnique = true)]
        public string PayTerm { get; set; }
    }
}