using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    [Table("TBL008", Schema = "dbo")]
    public class TBL008
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public Guid CardGuide { get; set; }

        [Required]
        [MaxLength(255)]
        public string CardCode { get; set; }

        [Required]
        public byte Security { get; set; }

        [Required]
        [MaxLength(255)]
        public string WarehouseName { get; set; }

        [MaxLength(255)]
        public string LatinName { get; set; }

        public Guid? MainWarehouse { get; set; }

        public Guid? TradingClosing { get; set; }

        public Guid? BalanceSheetClosing { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        [Column(TypeName = "image")]
        public byte[] CardImage { get; set; }

        public Guid? ByUser { get; set; }

        public Guid? ByGroup { get; set; }

        [Required]
        public bool NotActive { get; set; }

        // Navigation properties for foreign keys
        [ForeignKey("MainWarehouse")]
        public virtual TBL008 MainWarehouseNavigation { get; set; }

        [ForeignKey("TradingClosing")]
        public virtual TBL002 TradingClosingNavigation { get; set; }

        [ForeignKey("BalanceSheetClosing")]
        public virtual TBL002 BalanceSheetClosingNavigation { get; set; }

        [ForeignKey("ByUser")]
        public virtual TBL013 ByUserNavigation { get; set; }

        [ForeignKey("ByGroup")]
        public virtual TBL042 ByGroupNavigation { get; set; }
    }
}
