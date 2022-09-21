using System;

public class Program
{
	public void Main()
	{
		weapon[] weaponsObjs = {new weapon(), new weapon(), new weapon()};
		Console.WriteLine(weaponsObjs[0].weaponName);
		weaponsObjs[1].weaponName = "Wooden Bow";
		weaponsObjs[1].weaponName = "Emerald Staff";

		foreach (var i=0;i<weaponsObjs.Length;1++){
			weaponsObjs[i].powerLevel = 2;
        }
		foreach (var item in weaponsObjs) {
			Console.WriteLine(item.weaponName);
		}
	}
}

public class weapon {
	public string weaponName = "Iron Rapier";
	public int powerLevel = 1;
}
