﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ApiModels
{
	public class AddUserRequest
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
	}
}
