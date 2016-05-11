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
		private int maxEnrollement;
		private string id;
		private int section;

		public string Description { 
			get { 
				return description;
			}
			set { 
				description = value; 
			}
		}

		public int Period { 
			get { 
				return period;
			}
			set { 
				period = value; 
			}
		}

		public int Credits { 
			get { 
				return credits;
			}
			set { 
				credits = value; 
			}
		}

		public int MaxEnrollment { 
			get { 
				return maxEnrollement;
			}
			set { 
				maxEnrollement = value; 
			}
		}

		public string ID { 
			get { 
				return id;
			}
		}

		public int Section { 
			get { 
				return section;
			}
		}

		public void SetCourseInfo(string newId, int newSection, string newDescription, int newPeriod, int newCredits, int newMaxEnrollment ){
			description = newDescription;
			period = newPeriod;
			id = newId;
			section = newSection;
			credits = newCredits;
			maxEnrollement = newMaxEnrollment;
		}

		public string PrintCourseInfo() {
			return (description + "(CourseID: " + id  + ", Section: " + section 
				+ "\nPeriod: " + period 
				+ "\nCredits: " + credits
				+ "\nMaximum Enrollment:" + MaxEnrollment);
		}
	}
}
