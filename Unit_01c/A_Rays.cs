using System;

public class Program
{
	public void Main()
	{
		// Getting lots of deja vu from this
		string[] breads = { "White", "Whole Wheat", "Muffins", "Baguette", "Toast", "Cake", "Pan Dulce", "Cornbread", "Bagels", "Donuts", "Banana Bread", "Waffle", "Biscotti", "Biscuit", "Rolls", "Crepe", "Pancake", "Foccacia", "Tortilla" };
		breads[4] = "HOLY TOAST";
		Console.WriteLine(breads[4]);
		Console.WriteLine(breads.Length);
		for (int i = 0; i < breads.Length; i++)
		{
			Console.WriteLine(breads[i]);
		}
	}
}