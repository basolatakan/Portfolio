using FluentValidation;

namespace Portfolio.Models.Validators
{
    public class UsersValidator : AbstractValidator<Users>
    {
        public UsersValidator()
        {
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Şifre boş olamaz!")
                .MinimumLength(8).WithMessage("Şifre en az 8 karakter olmalıdır!");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("E-posta adresi boş olamaz!")
                .EmailAddress().WithMessage("Geçerli bir e-posta adresi giriniz!");


        }
    }
}
