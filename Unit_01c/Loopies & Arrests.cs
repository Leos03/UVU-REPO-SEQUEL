using System;

public class Program
{
	public void Main()
	{
		string[] breads = { "White", "Whole Wheat", "Muffins", "Baguette", "Toast", "Cake", "Pan Dulce", "Cornbread", "Bagels", "Donuts", "Banana Bread", "Waffle", "Biscotti", "Biscuit", "Rolls", "Crepe", "Pancake", "Foccacia", "Tortilla" };
		Console.WriteLine(breads.Length);
		Console.WriteLine(breads[5] + " " + breads[15]);
		foreach(var bread in breads) {
			Console.WriteLine("All hail the almighty " + bread);
		}
	}
}
