﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMProjectArea.DTO.Concrete.Account
{
	public class UserAccountDTO
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public string Email { get; set; }
		public List<string>  Roles { get; set; }
	}
}
