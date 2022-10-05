using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypeScript : MonoBehaviour
{
    void Start()
    {
        //Value type var
        Vector3 pos = transform.position;
        pos = new Vector3(0, 2, 0);

        //Ref type var
        Transform tran = transform;
        tran.position = new Vector3(0, 2, 0);
    }
}