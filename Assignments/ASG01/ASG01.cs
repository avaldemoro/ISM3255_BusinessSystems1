/*
Group Names: Aster Valdemoro, Shelby Carr, Dana Tam, Briana Burrows, Rey Pierre
Group Number: 3
*/

using System;

namespace class02_a {
	class MainClass {
		public static void Main (string[] args) {
			string s1=  "1ABACCDEEAD"; 
			string s2=  "2DBABCAEEAD";
			string s3=  "3EDDACBEEAD";
			string s4=  "4CBAEDCEEAD";
			int grade1 = 0;
			int grade2 = 0;
			int grade3 = 0;
			int grade4 = 0;

			string keys= "DBDCCDAEAD";
			for (int i = 1; i <= 10; i++) {
				if (s1[i] == keys[i-1]) {
					grade1 = ++grade1;
				}
				if (s2[i] == keys[i-1]) {
					grade2 = ++grade2;
				}
				if (s3[i] == keys[i-1]) {
					grade3 = ++grade3;
				}
				if (s4[i] == keys[i-1]) {
					grade4 = ++grade4;
				}
					
			}

			Console.WriteLine ("Students Number    Student Grade");  
			Console.WriteLine ("1                  " + grade1);
			Console.WriteLine ("2                  " + grade2);
			Console.WriteLine ("3                  " + grade3);
			Console.WriteLine ("4                  " + grade4);

		}
	}
}
