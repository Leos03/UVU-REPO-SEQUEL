using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 30.0f;
    public float lowerBounds = -10.0f;

    void Awake()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if(transform.position.z)
    }
}
