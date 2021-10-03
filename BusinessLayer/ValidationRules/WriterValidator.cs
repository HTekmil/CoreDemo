using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator: AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı ve Soyadı boş bırakılamaz!");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş bırakılamaz!");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş bırakılamaz!");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Adınız ve Soyadınız 2 harften küçük olamaz!");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Adınız ve Soyadınız 50 harften büyük olamaz!");

        }
    }
}
