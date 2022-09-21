using System;

public class Program
{
	public void Main()
	{
		weapon[] weaponsObjs = {new weapon()};
		Console.WriteLine(weaponsObjs[0].weaponName);
	}
}

public class weapon {
	public string weaponName = "Iron Rapier";
	public int powerLevel = 1;
}
