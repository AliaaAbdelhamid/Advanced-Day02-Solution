using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DefaultConstraint
{
	internal class TypeB : TypeA
	{
		public override void MyFun01<T>(T? value)
		{
			base.MyFun01(value);
		}

		public override void MyFun02<T>(T? value) where T : default
		{
			base.MyFun02(value);
		}
	}
}
