using System;
namespace Class05
{
	class MainClass
	{
		public static void Main ()
		{
			Console.WriteLine ("Enter Course Description: ");
			string myDescription = Console.ReadLine ();

			Console.WriteLine ("Enter Course Period: ");
			int myPeriod = int.Parse(Console.ReadLine ());

			Console.WriteLine ("Enter Course Credits: ");
			int myCredits = int.Parse(Console.ReadLine ());

			Console.WriteLine ("Enter Max Enrollment: ");
			int myMaxEnrollment = int.Parse(Console.ReadLine ());

			Console.WriteLine ("Enter Student ID: ");
			string myId = Console.ReadLine ();

			Console.WriteLine ("Enter Course Section: ");
			int mySection = int.Parse(Console.ReadLine ());


			Course course1 = new Course (myDescription, myPeriod, myCredits, myMaxEnrollment, myId, mySection);

			Console.WriteLine (course1.PrintCourseInfo());

		}
	}
}
