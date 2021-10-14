using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(w => w.WriterName).NotEmpty().WithMessage("Yazar adı soyadı boş geçilemez.");
            RuleFor(w => w.Email).NotEmpty().WithMessage("Mail adresi boş geçilemez.");
            RuleFor(w => w.Password).NotEmpty().WithMessage("Şifre boş geçilemez.").Must(IsPasswordValid).WithMessage("Şifre en az bir büyük harf, en az bir küçük harf içermeli ve bir sayı olmalıdır!");
            RuleFor(x => x.WriterPasswordAgain).NotEmpty().WithMessage("Şifre tekrarı boş geçilemez!").Must(IsPasswordValid).WithMessage("Şifre en az bir büyük harf, bir küçük harf içermeli ve bir sayı olmalıdır!");
            RuleFor(w => w.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter giriniz.");
            RuleFor(w => w.WriterName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakterlik veri girişi yapınız.");
        }

        private bool IsPasswordValid(string arg)
        {
            try
            {
                Regex regex = new Regex(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[0-9])[A-Za-z\d]");
                return regex.IsMatch(arg);
            }
            catch
            {
                return false;
            }
        }
    }
}
