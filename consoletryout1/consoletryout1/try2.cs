using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using MessageCenter;
namespace consoletryout1
{

	public class try2: MessageBase
	{
		public try2()
		{
			Console.WriteLine("init try2");
			
		}
		static try2()
		{
			Msgc.SubscribeStatics(typeof(try2));
		}
		public async void Message(int i1)
		{
			Console.WriteLine("int " + i1);
		}
		public async void Message(double d1)
		{
			
			
			Console.WriteLine("double " + d1);
		}

		public static async void Message(string s)
		{
			Console.WriteLine("string " + s);
		}

		
	}
}
