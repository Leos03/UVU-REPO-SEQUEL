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
        // Set horizontal input to get values from the noisy letter button board
        horizontalInput = Input.GetAxis("Horizontal");
        // Player go L & R
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
