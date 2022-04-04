using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoletryout1
{
	public class try1 : MessageBase
	{
		public string name { get; set; }
		public void func(int i1)
		{
			this.MemberwiseClone();
		}
		public void func(double d1)
		{

		}
	}
}
