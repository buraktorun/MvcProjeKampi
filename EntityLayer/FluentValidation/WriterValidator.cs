using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.FluentValidation
{
	public class WriterValidator : AbstractValidator<Writer>
	{
		public WriterValidator() 
		{
			RuleFor(X => X.WriterName).NotEmpty().WithMessage("lÜTFEN BOŞ BIRAKMAYINIZ");
		}
	}
}
