using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MySoCont : MonoBehaviour
{
	public Chara info;

	public Text nameText;

	public Text magicText;
	public Text attackText;
	public Text hpText;

	void Start()
	{
		nameText.text = info.name;
		magicText.text = info.magicCost.ToString();
		attackText.text = info.attack.ToString();
		hpText.text = info.hp.ToString();
	}

}