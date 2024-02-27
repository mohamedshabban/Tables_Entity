using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Data
{
    [Table("TBL016", Schema = "dbo")]
    public class TBL016
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public Guid CardGuide { get; set; }

        [Required]
        [MaxLength(255)]
        public string AgentName { get; set; }

        [MaxLength(255)]
        public string Prefix { get; set; }

        [MaxLength(255)]
        public string LatinName { get; set; }

        [MaxLength(255)]
        public string BirthPlace { get; set; }

        [MaxLength(255)]
        public string Suffix { get; set; }

        [MaxLength(255)]
        public string IDNumber { get; set; }

        [MaxLength(255)]
        public string Passport { get; set; }

        [MaxLength(255)]
        public string FirstName { get; set; }

        [MaxLength(255)]
        public string FatherName { get; set; }

        [MaxLength(255)]
        public string LastName { get; set; }

        [MaxLength(255)]
        public string TaxCode { get; set; }

        [MaxLength]
        public string MotherName { get; set; }

        [Required]
        public int CardNumber { get; set; }

        [Required]
        public int Gender { get; set; }

        [Required]
        public byte Security { get; set; }

        [Required]
        public byte SalaryType { get; set; }

        [Required]
        public float FixedSalary { get; set; }

        [Required]
        public float DaySalary { get; set; }

        [Required]
        public float CostPercentage { get; set; }

        [Required]
        public bool NotActive { get; set; }

        public DateTime? Birthdate { get; set; }

        public DateTime? DateStart { get; set; }

        public DateTime? DateBegin { get; set; }

        public DateTime? DateEnd { get; set; }

        [Required]
        public float MaxDebit { get; set; }

        [Required]
        public float MaxCredit { get; set; }

        [Required]
        public float NotepaperMaxDebit { get; set; }

        [Required]
        public float NotepaperMaxCredit { get; set; }

        [MaxLength(255)]
        public string Religion { get; set; }

        [MaxLength(255)]
        public string Maritalstatus { get; set; }

        public DateTime? DateValue1 { get; set; }

        public DateTime? DateValue2 { get; set; }

        public DateTime? DateValue3 { get; set; }

        public DateTime? DateValue4 { get; set; }

        public DateTime? DateValue5 { get; set; }

        public DateTime? DateValue6 { get; set; }

        public DateTime? DateValue7 { get; set; }

        public DateTime? DateValue8 { get; set; }

        public DateTime? DateValue9 { get; set; }

        public DateTime? DateValue0 { get; set; }

        [Required]
        public bool DetailingItems { get; set; }

        [Required]
        public bool BitValue1 { get; set; }

        [Required]
        public bool BitValue2 { get; set; }

        [Required]
        public bool BitValue3 { get; set; }

        [Required]
        public bool BitValue4 { get; set; }

        [Required]
        public bool BitValue5 { get; set; }

        [Required]
        public bool BitValue6 { get; set; }

        [Required]
        public bool BitValue7 { get; set; }

        [Required]
        public bool BitValue8 { get; set; }

        [Required]
        public bool BitValue9 { get; set; }

        [Required]
        public bool BitValue10 { get; set; }

        [Required]
        public bool BitValue11 { get; set; }

        [Required]
        public bool CreditNotAllowed { get; set; }

        [Required]
        public int DueAge { get; set; }

        [Required]
        public int DueAgeAmount { get; set; }

        public Guid? DueAgeType { get; set; }

        [Required]
        public float FloatValue1 { get; set; }

        [Required]
        public float FloatValue2 { get; set; }

        [Required]
        public float FloatValue3 { get; set; }

        [Required]
        public float FloatValue4 { get; set; }

        [Required]
        public float FloatValue5 { get; set; }

        [Required]
        [MaxLength]
        public string Barcode { get; set; }

        [Required]
        public byte PriceType { get; set; }

        [MaxLength]
        public string Phone { get; set; }

        [MaxLength]
        public string Phone2 { get; set; }

        [MaxLength]
        public string Mobile { get; set; }

        [Required]
        public bool SubjectToTax { get; set; }

        [MaxLength]
        public string Fax { get; set; }

        [Required]
        public float MaxDiscountRatio { get; set; }

        [Required]
        public int DefaultPriceType { get; set; }

        [MaxLength]
        public string Nationality { get; set; }

        [MaxLength]
        public string CitySubdivision { get; set; }

        [MaxLength]
        public string PlotIdentification { get; set; }

        [MaxLength]
        public string Sponsor { get; set; }

        [MaxLength]
        public string TextValue1 { get; set; }

        [MaxLength]
        public string TextValue2 { get; set; }

        [MaxLength]
        public string TextValue3 { get; set; }

        [MaxLength]
        public string TextValue4 { get; set; }

        [MaxLength]
        public string TextValue5 { get; set; }

        [MaxLength]
        public string TextValue6 { get; set; }

        [MaxLength]
        public string TextValue7 { get; set; }

        [MaxLength]
        public string TextValue8 { get; set; }

        [MaxLength]
        public string TextValue9 { get; set; }

        [MaxLength]
        public string TextValue0 { get; set; }

        [MaxLength]
        public string TextValue10 { get; set; }

        [MaxLength]
        public string TextValue11 { get; set; }

        [MaxLength]
        public string TextValue12 { get; set; }

        [MaxLength]
        public string TextValue13 { get; set; }

        [MaxLength]
        public string TextValue14 { get; set; }

        [MaxLength]
        public string TextValue15 { get; set; }

        [Required]
        public byte RadioValue1 { get; set; }

        [Required]
        public int NumberValue1 { get; set; }

        [Required]
        public int NumberValue2 { get; set; }

        [Required]
        public int NumberValue3 { get; set; }

        [Required]
        public int NumberValue4 { get; set; }

        [Required]
        public int NumberValue5 { get; set; }

        [Required]
        public int NumberValue6 { get; set; }

        [Required]
        public int NumberValue7 { get; set; }

        [Required]
        public int NumberValue8 { get; set; }

        [Required]
        public int NumberValue9 { get; set; }

        [Required]
        public int NumberValue0 { get; set; }

        [Required]
        public bool CheckBoxValue1 { get; set; }

        [Required]
        public bool CheckBoxValue2 { get; set; }

        [Required]
        public bool CheckBoxValue3 { get; set; }

        [Required]
        public bool CheckBoxValue4 { get; set; }

        [Required]
        public bool CheckBoxValue5 { get; set; }

        [Required]
        public bool CheckBoxValue6 { get; set; }

        [Required]
        public bool CheckBoxValue7 { get; set; }

        [Required]
        public bool CheckBoxValue8 { get; set; }

        [Required]
        public bool CheckBoxValue9 { get; set; }

        [Required]
        public bool CheckBoxValue0 { get; set; }

        [Required]
        public bool CheckBoxValue10 { get; set; }

        [Required]
        public bool CheckBoxValue11 { get; set; }

        [Required]
        public bool CheckBoxValue12 { get; set; }

        [Required]
        public bool CheckBoxValue13 { get; set; }

        [Required]
        public bool CheckBoxValue14 { get; set; }

        [Required]
        public bool CheckBoxValue15 { get; set; }

        [MaxLength]
        public string Note { get; set; }

        [MaxLength]
        public string Note2 { get; set; }

        [MaxLength]
        public string Email { get; set; }

        [Required]
        public bool ShowInReport { get; set; }

        [MaxLength]
        public string Address { get; set; }

        [Required]
        public int Country { get; set; }

        [Required]
        public int Governorate { get; set; }

        [Required]
        public int City { get; set; }

        [Required]
        public int Area { get; set; }

        [Required]
        public int Street { get; set; }

        [Required]
        public int Building { get; set; }

        [Required]
        public int Floor { get; set; }

        [Required]
        public int Office { get; set; }

        [Required]
        public int Phone1 { get; set; }

        [Required]
        public int Mobile1 { get; set; }

        [Required]
        public int Fax1 { get; set; }

        [MaxLength]
        public string Code { get; set; }

        [MaxLength]
        public string Code1 { get; set; }

        [MaxLength]
        public string Code2 { get; set; }

        [MaxLength]
        public string Code3 { get; set; }

        [MaxLength]
        public string Code4 { get; set; }

        [MaxLength]
        public string Code5 { get; set; }

        [MaxLength]
        public string Code6 { get; set; }

        [MaxLength]
        public string Code7 { get; set; }

        [MaxLength]
        public string Code8 { get; set; }

        [MaxLength]
        public string Code9 { get; set; }

        [MaxLength]
        public string Code0 { get; set; }

        [MaxLength]
        public string Code11 { get; set; }

        [MaxLength]
        public string Code12 { get; set; }

        [MaxLength]
        public string Code13 { get; set; }

        [MaxLength]
        public string Code14 { get; set; }

        [MaxLength]
        public string Code15 { get; set; }

        [MaxLength]
        public string Code16 { get; set; }

        [MaxLength]
        public string Code17 { get; set; }

        [MaxLength]
        public string Code18 { get; set; }

        [MaxLength]
        public string Code19 { get; set; }

        [MaxLength]
        public string Code20 { get; set; }
    }
}
