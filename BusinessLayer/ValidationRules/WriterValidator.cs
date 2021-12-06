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
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("E-Posta adresi boş bırakılamaz!");
            RuleFor(x => x.WriterMail).EmailAddress().WithMessage("Geçerli bir e-posta adresi giriniz!");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş bırakılamaz!");
            RuleFor(x => x.WriterPassword).Length(1, 30).Matches(@"[A-Z]+").WithMessage("Şifreniz en az bir büyük karakter içermelidir!");
            RuleFor(x => x.WriterPassword).Length(1, 30).Matches(@"[a-z]+").WithMessage("Şifreniz en az bir küçük karakter içermelidir!");
            RuleFor(x => x.WriterPassword).Length(1, 30).Matches(@"[0-9]+").WithMessage("Şifreniz en az bir rakam içermelidir!");
            RuleFor(x => x.WriterPassword).Matches(@"[\!\?\*\.]+").WithMessage("Şifreniz en az bir adet (!? *.) karakterlerinden içermelidir!");
            /*RuleFor(x => x.WriterPasswordAgain).NotEmpty().WithMessage("Şifre boş bırakılamaz!");
            RuleFor(x => x.WriterPasswordAgain).Length(1, 30).Matches(@"[A-Z]+").WithMessage("Şifreniz en az bir büyük karakter içermelidir!");
            RuleFor(x => x.WriterPasswordAgain).Length(1, 30).Matches(@"[a-z]+").WithMessage("Şifreniz en az bir küçük karakter içermelidir!");
            RuleFor(x => x.WriterPasswordAgain).Length(1, 30).Matches(@"[0-9]+").WithMessage("Şifreniz en az bir rakam içermelidir!");
            RuleFor(x => x.WriterPasswordAgain).Matches(@"[\!\?\*\.]+").WithMessage("Şifreniz en az bir adet (!? *.) karakterlerinden içermelidir!");*/
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Adınız ve Soyadınız 2 harften küçük olamaz!");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Adınız ve Soyadınız 50 harften büyük olamaz!");
            //RuleFor(x => x).Custom((x, context) =>
            //{
            //    if (x.WriterPassword != x.WriterPasswordAgain)
            //    {
            //        context.AddFailure(nameof(x.WriterPassword), "Şifreniz eşleşmedi!");
            //    }
            //});

        }
    }
}
