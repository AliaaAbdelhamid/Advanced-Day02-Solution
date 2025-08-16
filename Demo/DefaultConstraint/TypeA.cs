using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DefaultConstraint
{
	internal class TypeA
	{
		public virtual void MyFun01<T>(T? value) where T : struct
		{
			Console.WriteLine(value);
		}
		public virtual void MyFun02<T>(T? value)
		{
			Console.WriteLine(value);
		}
	}
}
