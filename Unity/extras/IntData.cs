﻿using UnityEngine;
using UnityEngin.UI;

[CreateAssetMenu]

public class IntData : ScriptableObject
{
    public int value;

    public void UpdateValue(int number)
    {
        value += number;
    }

    public void ReplaceValue (int number)
    {
        value = number;
    }

    public void DisplayImage(Image img)
    {
        img.fillamount
    }
}