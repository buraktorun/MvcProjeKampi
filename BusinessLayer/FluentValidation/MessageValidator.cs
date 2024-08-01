using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
	public class MessageValidator : AbstractValidator<Message>
	{
		public MessageValidator() 
		
		{
			RuleFor(x => x.MessageContent).MinimumLength(5).WithMessage("Lütfen daha uzun karakter giriniz");
		}
	}

}
