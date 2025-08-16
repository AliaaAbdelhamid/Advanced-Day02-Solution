using System.Collections;

namespace Demo
{
	internal class Program
	{
		public static int SumArrayList(ArrayList? arrayList)
		{
			int Sum = 0;
			if (arrayList is not null)
				for (int i = 0; i < arrayList.Count; i++)
					Sum += (int?)arrayList[i] ?? 0;
			return Sum;
		}

		public static int SumList(List<int>? list)
		{
			int Sum = 0;
			if(list?.Count > 0)
				for (int i = 0; i < list.Count; i++)
					Sum += list[i];
			return Sum;
		}
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

			#region ArrayList 
			//ArrayList arrayList = new ArrayList();
			// ArrayList Internally is an array of object 
			// ArrayList Has Capacity Which is Number Of Elements That It Can Hold 
			// and Has Count Which is Number of Element That It Actually Hold 
			// Using Parameterless Constructor Of ArrayList Which Initialize Array Of _items = Array.Empty<object>();
			// Array.Empty<object>() => new object[0]

			#region Add Element 
			//arrayList.Add(1); // Boxing 
			//				  // Add New Element To The End Of ArrayList 
			//				  // The size[Count] Of The ArrayList Increased By One 
			//				  // And If Required , The Capacity of The ArrayList Is Doubled Before Adding New Element

			//Console.WriteLine("after Adding 1st Element");
			//Console.WriteLine($"Capacity : {arrayList.Capacity}"); // 4
			//Console.WriteLine($"Count : {arrayList.Count}"); // 1

			//arrayList.AddRange(new[] { 2, 3, 4 });
			//Console.WriteLine("after Adding 2nd , 3rd , 4th Element");
			//Console.WriteLine($"Capacity : {arrayList.Capacity}"); // 4
			//Console.WriteLine($"Count : {arrayList.Count}"); // 4

			//arrayList.Add(5);
			//// After Adding 5th Element
			//// Capacity was 4 => Not Enough
			//// Capacity Will Be Doubled => new Capacity = 8
			//Console.WriteLine("after Adding 5th Element");
			//Console.WriteLine($"Capacity : {arrayList.Capacity}"); // 8
			//Console.WriteLine($"Count : {arrayList.Count}"); // 5

			#endregion

			#region Insert Element 

			//Console.WriteLine("============== Insert Element ==============");
			//Console.WriteLine($"Capacity : {arrayList.Capacity}"); // 8
			//Console.WriteLine($"Count : {arrayList.Count}"); // 5
			//Console.Write("===========\n");
			//Console.WriteLine("Array List");
			//foreach (int item in arrayList) Console.Write($"{item} "); // 1 2 3 4 5
			//arrayList.Insert(1, 10);
			//Console.Write("\n===========\n");
			//Console.WriteLine("After Inserting 10 in index 1");
			//foreach (int item in arrayList) Console.Write($"{item} "); // 1 10 2 3 4 5

			//Console.Write("\n===========\n");
			//arrayList.Insert(6, 20); // insertions at the end are legal
			//Console.WriteLine("After Inserting 20 in index 6");
			//foreach (int item in arrayList) Console.Write($"{item} "); // 1 10 2 3 4 5 20

			#endregion

			#region Trim Space 

			//Console.WriteLine("\n============== Trim Space ==============");
			//arrayList.TrimToSize();
			//Console.WriteLine($"Capacity : {arrayList.Capacity}"); // 7
			//Console.WriteLine($"Count : {arrayList.Count}"); // 7
			//arrayList.Add(100);
			//Console.WriteLine("After Adding 100\n=================");
			//Console.WriteLine($"Capacity : {arrayList.Capacity}"); // 14
			//Console.WriteLine($"Count : {arrayList.Count}"); // 8

			#endregion

			#region Remove Element

			//Console.WriteLine("============== Remove Element ==============");
			//Console.WriteLine($"Capacity : {arrayList.Capacity}"); // 14
			//Console.WriteLine($"Count : {arrayList.Count}"); // 8
			//foreach (int item in arrayList) Console.Write($"{item} "); // 1 10 2 3 4 5 20 100

			//arrayList.Remove(10); // Remove The First Occurrence
			//Console.WriteLine("\nAfter Remove 10");
			//foreach (int item in arrayList) Console.Write($"{item} "); // 1 2 3 4 5 20 100

			//arrayList.RemoveAt(0); // Removes The Element At Index
			//Console.WriteLine("\nAfter Removing Element At Index 0");
			//foreach (int item in arrayList) Console.Write($"{item} "); // 2 3 4 5 20 100

			//arrayList.RemoveRange(1, 2);
			//Console.WriteLine("\nAfter Removing 2 Elements From Index 1 ");
			//foreach (int item in arrayList) Console.Write($"{item} "); // 2 5 20 100

			#endregion

			#region Access Element Like Array By Index 

			//Console.WriteLine("\n============== Access Element Like Array By Index ==============");
			//Console.WriteLine($"Capacity : {arrayList.Capacity}"); // 14
			//Console.WriteLine($"Count : {arrayList.Count}"); // 4
			//foreach (int item in arrayList) Console.Write($"{item} "); // 2 5 20 100

			//int FirstElement = (int?)arrayList[0] ?? 0;
			//Console.WriteLine($"\nFirst Element = {FirstElement}"); // 2 

			//Console.WriteLine("Use Indexer To Change Value");
			//arrayList[0] = 200; // Boxing 
			//foreach (int item in arrayList) Console.Write($"{item} "); // 200 5 20 100

			#endregion

			#region Check If Element Exists 

			//Console.WriteLine("\n============== Check If Element Exists ==============");
			//foreach (int item in arrayList) Console.Write($"{item} "); // 200 5 20 100
			//bool Flag = arrayList.Contains(100);
			//Console.WriteLine($"\n{Flag}"); // True

			#endregion

			#region Using 3 Constructor

			//arrayList = new ArrayList();
			//Console.WriteLine("arrayList = new ArrayList()");
			//Console.WriteLine($"Capacity : {arrayList.Capacity}"); // 0
			//Console.WriteLine($"Count : {arrayList.Count}"); // 0
			//arrayList = new ArrayList() { 10, 20, 30, 40, 50 };
			//// 3 array Created :
			//// 1st => With size 0
			//// 2nd => With Default Capacity 4
			//// 3rd => With Double Capacity 8 
			//Console.WriteLine("arrayList = new ArrayList() { 10, 20, 30, 40, 50 }");
			//Console.WriteLine($"Capacity : {arrayList.Capacity}"); // 8
			//Console.WriteLine($"Count : {arrayList.Count}"); // 5

			//arrayList = new ArrayList(10) { 1, 2, 3, 4, 5 };
			//Console.WriteLine("arrayList = new ArrayList(10) { 1, 2, 3, 4, 5 }");
			//Console.WriteLine($"Capacity : {arrayList.Capacity}"); // 10
			//Console.WriteLine($"Count : {arrayList.Count}"); // 5


			//arrayList = new ArrayList(new[] { 1, 2, 3, 4, 5 });
			//Console.WriteLine("arrayList = new ArrayList(new[] { 1, 2, 3, 4, 5 })");
			//Console.WriteLine($"Capacity : {arrayList.Capacity}"); // 5
			//Console.WriteLine($"Count : {arrayList.Count}"); // 5

			#endregion

			#region ArrayList DisAdvantanges 

			//ArrayList arrayList = new ArrayList(5);
			//arrayList.Add(1); // Boxing 
			//arrayList.Add(2); // Boxing 
			//arrayList.Add(3); // Boxing 
			//arrayList.Add(4); // Boxing 
			////arrayList.Add("Route"); // Can not Enforce Type Safety 

			//int Result = SumArrayList(arrayList);

			//Console.WriteLine(Result); // 10
			//foreach (int item in arrayList) // UnBoxing
			//	Console.Write($"{item} "); // 1 2 3 4

			#endregion

			#endregion

			#region Generic Collections - List<T>

			//List<int> list = new List<int>();
			// List Internally is an array of T 
			// List Has Capacity Which is Number Of Elements That It Can Hold 
			// and Has Count Which is Number of Element That It Actually Hold 
			// Using Parameterless Constructor Of List Which Initialize Array Of _items = s_emptyArray
			// Which is a static readonly Attribute Initialized With = new T[0]	

			#region Adding Element
			//Console.WriteLine("========== Adding Element ==========");
			//Console.WriteLine($"List Capacity = {list.Capacity} , List Count = {list.Count}"); // 0 , 0
			//list.Add(1);
			//Console.WriteLine("after Adding 1st Element");
			//Console.WriteLine($"List Capacity = {list.Capacity} , List Count = {list.Count}"); // 4 , 1

			//list.AddRange(2, 3, 4);
			//Console.WriteLine("after Adding 2nd , 3rd , 4th Element");
			//Console.WriteLine($"List Capacity = {list.Capacity} , List Count = {list.Count}"); // 4 , 4

			//list.Add(5);
			//Console.WriteLine("after Adding 5th Element");
			//Console.WriteLine($"List Capacity = {list.Capacity} , List Count = {list.Count}"); // 8 , 5

			#endregion

			#region Insert Element
			
			//Console.WriteLine("========== Insert Element ==========");
			//Console.WriteLine($"List Capacity = {list.Capacity} , List Count = {list.Count}"); // 8 , 5
			//Console.Write("List : ");
			//foreach (int item in list) Console.Write($"{item} "); // 1 2 3 4 5

			//list.Insert(5, 10);
			//Console.WriteLine("\nAfter Insert 10 in Index 1\n==========================");
			//Console.WriteLine($"List Capacity = {list.Capacity} , List Count = {list.Count}"); // 8 , 5
			//Console.Write("List :");
			//foreach (int item in list) Console.Write($" {item} "); // 1  10  2  3  4  5

			#endregion

			#region Trim Space 

			//Console.WriteLine("\n========== Trim Space ==========");
			//Console.WriteLine($"List Capacity = {list.Capacity} , List Count = {list.Count}"); // 8 , 6
			//list.Add(100);
			//Console.WriteLine($"List Capacity = {list.Capacity} , List Count = {list.Count}"); // 8 , 7
			//list.TrimExcess(); // if  size is not < threshold No Trimming Will Done 
			//Console.WriteLine("After Trim");
			//Console.WriteLine($"List Capacity = {list.Capacity} , List Count = {list.Count}"); // 6 , 6
			//list.Add(100);
			//Console.WriteLine("After Adding New Element");
			//Console.WriteLine($"List Capacity = {list.Capacity} , List Count = {list.Count}"); // 12 , 7

			#endregion

			#region Remove Element 

			//Console.WriteLine("\n========== Remove Element ==========");
			//Console.WriteLine($"List Capacity = {list.Capacity} , List Count = {list.Count}"); // 8 , 8
			//Console.Write("List :");
			//foreach (int item in list) Console.Write($" {item} "); //  1  2  3  4  5  10  100  100

			//list.Remove(100); // Remove The First Occurrence 
			//Console.Write("\nList After list.Remove(100) :");
			//foreach (int item in list) Console.Write($" {item} "); // 1  3  4  5  10  100

			//list.RemoveAt(1); // Remove The Element At Specific Index 

			//Console.Write("\nList After list.RemoveAt(1) :");
			//foreach (int item in list) Console.Write($" {item} "); // 1  3  4  5  10  100

			//list.RemoveRange(1, 2);
			//Console.Write("\nList After list.RemoveRange(1, 2) :");
			//foreach (int item in list) Console.Write($" {item} "); // 1  3  4  5  10  100

			#endregion

			#region Access Element In List 

			//Console.WriteLine("\n========== Access Element In List ==========");
			//Console.WriteLine(value: $"List Capacity = {list.Capacity} , List Count = {list.Count}"); // 8 , 4
			//Console.Write("List :");
			//foreach (int item in list) Console.Write($" {item} "); //  1  5  10  100

			//int FirstElement = list[0];
			//Console.WriteLine($"\nFirst Element = {FirstElement}"); // 1

			//Console.WriteLine("Use Indexer To Change Value");
			//list[0] = 200;
			//Console.Write("List :");
			//foreach (int item in list) Console.Write($" {item} "); // 200  5  10  100

			#endregion

			#region Check If Element Exists 
			//Console.WriteLine("\n========== Check If Element Exists  ==========");

			//Console.Write("List :");
			//foreach (int item in list) Console.Write($" {item} "); // 200  5  10  100
			//bool Flag = list.Contains(100);
			//Console.WriteLine($"\n{Flag}"); // True
			#endregion

			#region Using 3 Constructor 
			//Console.WriteLine("\n=========== Using 3 Constructor ===========");
			//list = new List<int>();
			//Console.WriteLine("list = List<int>()");
			//Console.WriteLine(value: $"List Capacity = {list.Capacity} , List Count = {list.Count}"); // 0 , 0

			//list = new List<int>() { 10, 20, 30, 40, 50 };
			//// 3 array Created :
			//// 1st => With size 0
			//// 2nd => With Default Capacity 4
			//// 3rd => With Double Capacity 8 
			//Console.WriteLine("list = new List<int>() { 10, 20, 30, 40, 50 }");
			//Console.WriteLine(value: $"List Capacity = {list.Capacity} , List Count = {list.Count}"); // 8 , 5


			//list = new List<int>(10) { 1, 2, 3, 4, 5 };
			//Console.WriteLine("list = new List<int>(10) { 1, 2, 3, 4, 5 }");
			//Console.WriteLine(value: $"List Capacity = {list.Capacity} , List Count = {list.Count}"); // 10 , 5



			//list = new List<int>([1, 2, 3, 4, 5]);
			//Console.WriteLine("list = new ArrayList(new[] { 1, 2, 3, 4, 5 })");
			//Console.WriteLine(value: $"List Capacity = {list.Capacity} , List Count = {list.Count}"); // 5 , 5

			#endregion

			#region Type Safety Of List 
			
			//list = new List<int>(5) { 1, 2, 3, 4};
			////list.Add("Route"); // Invalid 
			//int Result = SumList(list);
			//Console.WriteLine($"Sum List = {Result}"); // 10

			#endregion

			#endregion
		}
	}
}
