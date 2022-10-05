using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleCharaScript : MonoBehaviour
{
    public class Stuff
    {
        public int arrow
        public int staff;
        public int sword;

        public Stuff(int arr, int sta, int swo)
        {
            arrow = arr;
            staff = sta;
            sword = swo;
        }
    }

    public Stuff mystuff = new Stuff(10, 7, 25);
    public float speed;
    public float turnSpeed;
    public Rigidbody arrowPrefab;
    public Transform firePosition;
    public float arrowSpeed;

    void Update()
    {
        Movement();
        Shoot();
    }


    void Movement ()
    {
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * forwardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }


    void shoot
    {
        if(Input.GetButtonDown("Fire1") && myStuff.arrows > 0)
        {
            Rigidbody arrowInstance = Instantiate(arrowPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
    arrowInstance.AddForce(firePosition.forward* arrowSpeed);
            myStuff.arrows--;
        }
    }
}
