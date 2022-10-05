using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public class Stuff
    {
        public int arrows;
        public int staff;
        public int sword;
        public float energy;

        public Stuff(int arr, int sta, int swo)
        {
            arrow = arr;
            staff = sta;
            sword = swo;
        }

        public Stuff(int arr, float en)
        {
            arrow = arr;
            energy = en;
        }

        // Constructor
        public Stuff()
        {
            arrow = 1;
            staff = 1;
            sword = 1;
        }
    }


    // Creating an Instance (an Object) of the Stuff class
    public Stuff myStuff = new Stuff(50, 5, 5);

    public Stuff myOtherStuff = new Stuff(50, 1.5f);

    void Start()
    {
        Debug.Log(myStuff.arrows);
    }
}