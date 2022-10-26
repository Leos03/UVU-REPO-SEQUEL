using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBasic : MonoBehaviour
{
    void Update ()
    {
        if(input.GetKey(KeyCode.Space))
        {
            Destroy(gameObject);
        }
    }
}
