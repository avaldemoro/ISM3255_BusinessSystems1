//Group Number: 3
//Rey Peirre, Briana Burrows, Shelby Carr, Aster Valdemoro

using System;
public class Program
{
	public static void Main()
	{
		Vehicle vehicle1 = new Car(1, "Green", "Italy", "Europe", 18);
		Vehicle vehicle2 = new Car(2, "Blue", "USA", "North America", 18);
		Vehicle vehicle3 = new Plane(3, "White", "USA", "North America", 120);
		vehicle1.Move ("France","Europe");
		vehicle2.Move ("France","Europe");
		vehicle3.Move ("France","Europe");
		Console.WriteLine ("\nVehicles Current Locations:" );
		Console.WriteLine ("Vehicle "+vehicle1.ID + " is now in " + vehicle1.Country);
		Console.WriteLine ("Vehicle "+vehicle2.ID + " is now in " + vehicle2.Country);
		Console.WriteLine ("Vehicle "+vehicle3.ID + " is now in " + vehicle3.Country);
	}
}

//--------------------------------------Class Vehicle------------------------------------------

public class Vehicle
{
	public int ID { get; set; }
	public string Color { get; set; }
	public string Country { get; set; }
	public string Continent { get; set; }

	public virtual void Move(string toCountry, string toContinent)
	{
		Country = toCountry;
		Continent = toContinent;
	}
	public Vehicle(int inID, string inColor, string inCountry, string inContinent)
	{
		ID = inID;
		Color = inColor;
		Country = inCountry;
		Continent = inContinent;
	}
}

//--------------------------------------Class Car------------------------------------------

public class Car:Vehicle
{
	public int NumOfWheels { get; set; }
	public Car(int inYear, string inColor, string inCountry, string inContinent, int inNumOfWheels)
		: base(inYear, inColor, inCountry, inContinent)
	{
		NumOfWheels = inNumOfWheels;
	}
	public override void Move(string toCountry, string toContinent){
		
		if (Continent != toContinent) {
			Console.WriteLine ("Car " + ID + " can't drive to " + toCountry);
		} else { 
			base.Move (toCountry, toContinent);
			Console.WriteLine ("Driving Car" + ID + " to " + toCountry);
		}

	}
}

////--------------------------------------Class Plane------------------------------------------

public class Plane:Vehicle
{
	public int Wingspan { get; set; }

	public Plane(int inYear, string inColor, string inCountry, string inContinent, int inWingspan)
		: base(inYear, inColor, inCountry, inContinent)
	{
		Wingspan = inWingspan;
	}
	public override void Move(string toCountry, string toContinent){
		base.Move (toCountry,toContinent);
		Console.WriteLine ("Flying Plane " + ID + " to " + toCountry);
	}
}