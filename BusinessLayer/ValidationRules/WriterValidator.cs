using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidator :AbstractValidator<Writer>
	{
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Soyadı boş geçilemez");
            RuleFor(X => X.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez");
			RuleFor(p => p.WriterMail).Matches(@"[@,.]+").WithMessage("Mail adresi @ ve . icermelidir");
			RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Sifre bos gecilemez");
			RuleFor(p => p.WriterPassword).Matches(@"[A-Z]+").WithMessage("Sifre en azı bir büyük harfden ibaret olmalıdır.");
			RuleFor(p => p.WriterPassword).Matches(@"[a-z]+").WithMessage("Sifre en azı bir kicik harfden ibaret olmalıdır.");
			RuleFor(p => p.WriterPassword).Matches(@"[0-9]+").WithMessage("Sifre en azı bir rakamdan ibaret olmalıdır.");
			RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter giriniz");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter giriniz");
        }
    }
}
