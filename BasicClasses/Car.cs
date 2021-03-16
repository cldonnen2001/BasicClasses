using System;
using System.Collections.Generic;
using System.Text;

namespace BasicClasses
{
	// constructors
	public class Car  // add access modifer "public", add class auto puts "class Car"
	{
		//constructors 1st and 2nd way
		public Car()  // same name as the class = "Car" //default constuctor this is blank but needs properties fields
		{

		}

		//3rd way passing thru constructor
		public Car(string make, string model, int year)  // method overloading 2nd constructor,defined in class
		{
			Make = make;  // takes string make2 and stores in Make property
			Model = model;
			Year = year;
		}
		//fields  - example not here

		//properites- example below
		public string Make { get; set; }  //Create a Make property of type string that is public (ge = read, set = write)
		public string Model { get; set; } //Create a Model property of type string that is public
		public int Year { get; set; }//Create a Year property of type int that is public

		//methods - example not here
 	}
}
