namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
			#region Default Primary Constraint
			//         Point? point = new Point(10, 20);
			//         TypeA typeA = new TypeA();
			//         typeA.MyFun01<Point>(point); // where T : struct
			//typeA.MyFun02<Point>(point); // No Constraint

			//         TypeB typeB = new TypeB();
			//typeB.MyFun01<Point>(point); // where T : struct
			//typeB.MyFun02<Point>(point); // where T : default 
			#endregion

		}
	}
}
