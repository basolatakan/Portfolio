using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models.ModelMatedataTypes
{
    public class SignUpMetadata
    {
        [Required(ErrorMessage ="İsim boş bırakılamaz")]
        [StringLength(50, ErrorMessage = "İsim en fazla 50 karakter olabilir.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyisim boş bırakılamaz")]
        [StringLength(50, ErrorMessage = "Soyisim en fazla 50 karakter olabilir.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email boş bırakılamaz")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        [StringLength(100, ErrorMessage = "Email en fazla 100 karakter olabilir.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre boş bırakılamaz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Telefon boş bırakılamaz")]
        public string Phone { get; set; }
    }
}
