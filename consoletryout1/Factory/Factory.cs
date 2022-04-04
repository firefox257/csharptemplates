using System;
using System.Collections.Generic;
using Interfaces;

namespace Factory
{
	public class Factory<T>
	{
		static Func<T> output { get; set; }
		public static void Set(Func<T> a)
		{
			output = a;
		}
		public static T Get()
		{
			return output();
		}
	}
}