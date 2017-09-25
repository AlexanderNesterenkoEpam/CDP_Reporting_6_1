﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebProject.Entities
{
	public class User
	{
		public string email { get; private set; }
		public string password { get; set; }

		public User(string email, string password)
		{
			this.email = email;
			this.password = password;
		}

		public User(string email)
		{
			this.email = email;
			this.password = "";
		}
	}
}
