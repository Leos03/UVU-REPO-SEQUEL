using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingInstantiate : MonoBehaviour
{
    public Rigidbody staffPrefab;
    public Transform barrelEnd;


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody staffInstance;
            staffInstance = Instantiate(staffPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            staffInstance.AddForce(barrelEnd.forward * 5000);
        }
    }
}