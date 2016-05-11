using System;

namespace Class05
{
	class MainClass
	{
		public static void Main ()
		{
			Course course1 = new Course ();

				string myDescription = "New";
				int myPeriod = 3;
				int myCredits = 6;
				int myMaxEnrollment = 5;

				string myId = "124589645";
				int mySection= 6595;

			
				Course course2 = new Course ();
				string mDescription = "New";
				int mPeriod = 3;
				int mCredits = 6;
				int mMaxEnrollment = 5;

				string mId = "124589645";
				int mSection= 6595;

					



			course1.SetCourseInfo (myId, mySection, myDescription, myPeriod, myCredits, myMaxEnrollment);
			course2.SetCourseInfo (mId, mSection, mDescription, mPeriod, mCredits, mMaxEnrollment);


			Console.WriteLine (course2.PrintCourseInfo());

			course2.MaxEnrollment = 9;

			Console.WriteLine (course2.PrintCourseInfo());
		}
	}
}
