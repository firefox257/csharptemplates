using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenIdentityData.Api
{
	public class ErrorResponse
	{
		public string Message { get; set; }
		public List<string> ExceptionErrors = new List<string>();
		
	}
}
