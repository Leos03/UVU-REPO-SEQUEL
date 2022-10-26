using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Rigidbody arrowPrefab;
    public Transform firePosition;
    public float arrowSpeed;


    private Inventory inventory;


    void Awake()
    {
        inventory = GetComponent<Inventory>();
    }


    void Update()
    {
        Shoot();
    }


    void Shoot()
    {
        if (Input.GetButtonDown("Fire1") && inventory.myStuff.arrows > 0)
        {
            Rigidbody arrowInstance = Instantiate(arrowPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
            arrowInstance.AddForce(firePosition.forward * arrowSpeed);
            inventory.myStuff.arrows--;
        }
    }
}
