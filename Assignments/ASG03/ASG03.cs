/*
Group Names: Aster Valdemoro, Shelby Carr, Dana Tam, Rey Pierre
Group Number: 3
*/
using System;

namespace class02_a {
	class MainClass {
		public static void Main (string[] args) {
			Console.Write("Please enter the key: ");
			string key = Console.ReadLine ();

			Console.Write("How many student answers are you entering? ");
			int numOfStudents = int.Parse(Console.ReadLine ());

			string[] students = new String[numOfStudents];
			double[] score = new double[numOfStudents];
			double[] percentScore = new double[numOfStudents];

			char letterGrade = 'A';
			double average = 1.0;
			double sumOfScores = 0.0;


			for (int i = 0; i < students.Length; i++) {
				Console.WriteLine ("Please enter answers of student " + (i+1) + ": ");
				students[i] = Console.ReadLine ();
			}
			Console.WriteLine ("Students Number\tScore\tScore%\tGrade");  

			for (int i = 0; i < students.Length; i++) {
				for (int j = 0; j < key.Length; j++) {
					if(students[i][j] == key[j]) {
						score[i] += 1 ;
					}
				}
				percentScore [i] = (score [i] / key.Length) * 100;

				if ((score [i] / key.Length) >= 0.90) {
					letterGrade = 'A';
				} else if ((score [i] / key.Length) >= 0.80) {
					letterGrade = 'B';
				} else if ((score [i] / key.Length) >= 0.70) {
					letterGrade = 'C';
				} else {
					letterGrade = 'F';
				}

				Console.WriteLine (i+1 + "\t\t" + score[i] + "\t" + percentScore[i].ToString("F") + "%\t" + letterGrade);

				sumOfScores += score [i];
				average = sumOfScores / (i+1);
			}
			Console.WriteLine ("Average score of all students: " + average.ToString("F"));
		}
	}
}
