using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhileLoop : MonoBehaviour
{
    void Start ()
    {
        bool shouldContinue = false;

        do
        {
            print("Oh, Ello...");
        } while (shouldContinue == true);
    }
}
