/*
Group Names: Aster Valdemoro, Shelby Carr, Dana Tam, Rey Pierre, Briana Burrows
Group Number: 3
*/

using System;
namespace Class05 {
	class Course {
		private string description;
		private int period;
		private int credits;
		private int maxEnrollment = 30;
		private string id;
		private int section;

		public string Description { get; set; }

		public int Period { get; set;}

		public int Credits { get; set;}

		public int MaxEnrollment { get; set;}

		public string ID { 
			get { return id; }
		}

		public int Section { 
			get { return section; }
		}

		public Course() {
			maxEnrollment = 30;
		}

		public Course(string inDescription, int inPeriod, int inCredits, int inMaxEnrollment, string inId, int inSection) {
			description = inDescription;
			period = inPeriod;
			credits = inCredits;
			if (inMaxEnrollment > 30) {
				inMaxEnrollment = 30;
			}

			id = inId;
			section = inSection;
		} 

		public string PrintCourseInfo() {
			return (description + "(CourseID: " + id  + ", Section: " + section 
				+ ")\nPeriod: " + period 
				+ "\nCredits: " + credits
				+ "\nMaximum Enrollment:" + maxEnrollment + "\n");
		}
	}
}
