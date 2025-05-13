using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models.ModelMatedataTypes
{
    public class UsersMetadata
    {
        [Required(ErrorMessage = "Lütfen Email'i giriniz.")]  //Gerekli olduğunu bildiren anotaiton
        [StringLength(100, ErrorMessage = "Email alanı en fazla 100 karaketer olabilir.")]
        [EmailAddress(ErrorMessage = "Doğru bir email adresi girin.")]  //Email formu için
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen Şifre'yi giriniz.")]  //Gerekli olduğunu bildiren anotaiton
        [StringLength(20, ErrorMessage = "Şifre alanı en fazla 20 karaketer olabilir.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen TC'yi giriniz.")]  //Gerekli olduğunu bildiren anotaiton
        [StringLength(11, ErrorMessage = "TC alanı en fazla 11 karaketer olabilir.")]
        public string IdNumber { get; set; } 
    }
}
