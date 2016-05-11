//Group Number: 3
//Aster Valdemoro

namespace asg3 {
	class Animal {
		private int age;
		private string name;

		public int Age {
			get { return age; }
			set { age = value; }
		}

		public string Name {
			get { return name; }
			set { name = value; }
		}
		public void SetAgeName(int inAge, string inName) { 
			age = inAge;
			name = inName;
		}

		public string PrintInfo() {
			return ("Name: " + name + "\nAge: " + age);
		}
	}
}

