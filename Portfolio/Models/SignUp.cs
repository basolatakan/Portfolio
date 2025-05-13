using Microsoft.AspNetCore.Mvc;
using Portfolio.Models.ModelMatedataTypes;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    [ModelMetadataType(typeof(SignUpMetadata))]
    public class SignUp
    {
        public int Id { get; }

        [Required(ErrorMessage = "Ad boş bırakılamaz")]
        [StringLength(50, ErrorMessage = "Ad en fazla 50 karakter olabilir.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyad boş bırakılamaz")]
        [StringLength(50, ErrorMessage = "Soyad en fazla 50 karakter olabilir.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email boş bırakılamaz")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        [StringLength(100, ErrorMessage = "Email en fazla 100 karakter olabilir.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre boş bırakılamaz")]
        [MinLength(6, ErrorMessage = "Şifre en az 6 karakter olmalıdır.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Telefon boş bırakılamaz")]
        [Phone(ErrorMessage = "Geçerli bir telefon numarası giriniz.")]
        public string Phone { get; set; }

        public SignUp() { }


        public SignUp(string firstName, string lastName, string email, string password, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Phone = phone;
        }

    }
}
