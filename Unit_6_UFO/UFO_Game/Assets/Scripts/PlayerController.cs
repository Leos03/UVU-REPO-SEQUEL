using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed; 

    void Start()
    {
        
    }

    void Update()
    {
        horizontalInput = horizontalInput.GetAxis("Horizontal");
    }
}
