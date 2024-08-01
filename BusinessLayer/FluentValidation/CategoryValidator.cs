using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.FluentValidation
{
	public class CategoryValidator : AbstractValidator<Category>
	{
		public CategoryValidator() 
		{
			RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Lütfen Kategori İsmini Boş Bırakmayınız ve en fazla 50 karakter yazınız.");
		}
	}
}
