// Brie Prater
// CIS 243
// 02/14/2020
// Assignment 10.1
// Create a console app that will take an array and parse it into a string array and a double array

using System;

public class Data
{
	public static void Main(string[] args) // main method for the program
	{
		string[] name_price = { "Widget 15.50", "Thingy 50.99", "Ratchet25.00", "Clanger115.49", "Fracker75.25" }; // initializes original array
		string[] name = new string[5]; // initializes empty string array with 5 indexes
		double[] price = new double[5]; // initializes empy double array with 5 indexes
		parseIt(name_price, ref name, ref price); // calls parseIt function
		for (int x = 0; x < name_price.Length; x++) // for loop to print parsed arrays
		{
			Console.WriteLine(name[x] + " $" + price[x].ToString()); // prints the name and price from new parsed arrays
		}
	}
	static void parseIt(string[] name_price, ref string[] name, ref double[] price) // method to parse name_price into seperate arrays
	{
		for (int y = 0; y < name_price.Length; y++) // for loop to iterate through length of name_price array
		{
			name[y] = name_price[y].Substring(0, 7); // sets the index of the counter in name to the string from name_price starting at 0 for the first 7 characters
			price[y] = Convert.ToDouble(name_price[y].Substring(7, 5)); // sets the index of the counter in price to the string from name_price starting at 7 for the following 5 characters
		}
	}

}