/*
Group Names: Aster Valdemoro, Shelby Carr, Dana Tam, Briana Burrows, Rey Pierre
Group Number: 3
*/

using System;

namespace class02_a {
	class MainClass {
		public static void Main (string[] args) {
			
			Console.WriteLine ("Please enter answers for student 5: ");
			string student5Answers = Console.ReadLine ();

			Console.WriteLine ("Please enter answers for student 6: ");
			string student6Answers = Console.ReadLine ();

			string[] students = new string[6]{"1ABACCDEEAD", "2DBABCAEEAD", "3EDDACBEEAD", "4CBAEDCEEAD", student5Answers, student6Answers};
			int[] score = new int[6];

			string keys = "DBDCCDAEAD";
			char letterGrade = 'A';

			Console.WriteLine ("Students Number    Score   Score%   Grade");  

			for (int i = 0; i < students.Length; i++) {
				for (int j = 1; j < 11; j++) {
					if(students[i][j] == keys[j-1]) {
						score[i] = ++score[i];
					}

				}


				if (score [i] <= 10 || score [i] >= 9) {
					letterGrade = 'A';
				}
				if (score [i] < 9 || score [i] >= 8) {
					letterGrade = 'B';
				}
				if (score [i] < 8 || score [i] >= 7) {
					letterGrade = 'C';
				} 
				if (score[i] < 7) {
					letterGrade = 'F';
				}
					  
				Console.WriteLine (i+1 + "                  " + score[i] + "   " +
					"    " + (score[i] * 10) + "%" + "      " +letterGrade);
			}
		}
	}
}
