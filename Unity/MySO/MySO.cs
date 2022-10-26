using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySo : ScriptableObject
{

	public new string name;
	public string description;

	public int magicCost;
	public int attack;

	public void Print()
	{
		Debug.Log(name + " " + description + " magicCost " + magicCost);
	}

}