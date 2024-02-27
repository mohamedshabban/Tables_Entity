using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    [Table("TBL002", Schema = "dbo")]
    public class TBL002
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
        [MaxLength(255)]
        public string ClosingAccountName { get; set; }

        [MaxLength(255)]
        public string ClosingAccountLatinName { get; set; }

        [Required]
        public byte Security { get; set; }

        public Guid? MasterCloseAccount { get; set; }

        public Guid? BeginningInventoryAccount { get; set; }

        public Guid? ClosingInventoryAccount { get; set; }

        public Guid? BalanceAccount { get; set; }

        [Required]
        public byte CloseAccounts { get; set; }

        [MaxLength(255)]
        public string DebitBalanceCaption { get; set; }

        [MaxLength(255)]
        public string CreditBalanceCaption { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        // Navigation properties for foreign keys
        [ForeignKey("MasterCloseAccount")]
        public virtual TBL002 MasterCloseAccountNavigation { get; set; }

        [ForeignKey("BeginningInventoryAccount")]
        public virtual TBL004 BeginningInventoryAccountNavigation { get; set; }

        [ForeignKey("ClosingInventoryAccount")]
        public virtual TBL004 ClosingInventoryAccountNavigation { get; set; }

        [ForeignKey("BalanceAccount")]
        public virtual TBL004 BalanceAccountNavigation { get; set; }
    }
}
