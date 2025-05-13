using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models.ModelMatedataTypes
{
    public class ForeignInvestorMetadataType
    {
        [Required(ErrorMessage = "Ad boş bırakılamaz")]
        [StringLength(50, ErrorMessage = "Ad en fazla 50 karakter olabilir.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyad boş bırakılamaz")]
        [StringLength(50, ErrorMessage = "Soyad en fazla 50 karakter olabilir.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email boş bırakılamaz")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        [StringLength(100, ErrorMessage = "Email en fazla 100 karakter olabilir.")]
        public int Email { get; set; }

        [Required(ErrorMessage = "Telefon boş bırakılamaz")]
        public int Phone { get; set; }

        [Required(ErrorMessage = "Tutar boş bırakılamaz")]
        public float Amount { get; set; }

        public string Adress { get; set; }

        [Required(ErrorMessage = "TCKN boş bırakılamaz")]
        [RegularExpression(@"^[A-Z0-9]{6,9}$", ErrorMessage = "Pasaport numarası 6-9 karakter uzunluğunda, sadece büyük harf ve rakamlardan oluşmalıdır.")]
        public string PassportNumber { get; set; }    //farklı olan 
    }
}
