//Group Number: 3
//Aster Valdemoro

using System;
namespace asg3 {
	class MainClass
	{
		static void Main ()
		{
			Animal obj1 = new Animal ();
			int animal1Age = 3;
			string animal1Name = "obj1";

			Animal obj2 = new Animal ();
			int animal2Age = 15;
			string animal2Name = "obj2";

			obj1.SetAgeName (animal1Age, animal1Name);
			obj2.SetAgeName (animal2Age, animal2Name);

			if (animal1Age < animal2Age) {
				Console.WriteLine ("The object with the larger int value is: " + animal2Name + "\n");
			} else {
				Console.WriteLine ("The object with the larger int value is: " + animal1Name + "\n");
			}
		
			Console.WriteLine(obj1.PrintInfo());
			Console.WriteLine(obj2.PrintInfo());
		}
	}
}