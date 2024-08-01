﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Contact
	{
		[Key]
		public int ContactId { get; set; }
		[StringLength(50)]
		public string UserName { get; set; }
		[EmailAddress]
		public string UserMail { get; set; }
		[StringLength(50)]
		public string Subject { get; set; }
		[StringLength(750)]
		public string Message { get; set; }

		public DateTime ContactDate { get; set; }
	}
}
