﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class About
	{
		[Key]
		public int AboutId { get; set; }
		[StringLength(500)]
		public string AboutDetails1 { get; set; }
		[StringLength(500)]
		public string AboutDetails2 { get; set; }
		[StringLength(250)]
		public string AboutImage1 { get; set; }
		[StringLength(250)]
		public string AboutImage2 { get; set; }
	}
}
