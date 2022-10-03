using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public Rigidbody TargetRigidbody;
    public float shootForce = 1000f;
    public float shootHeight = 400f;
    private bool CanShot = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "boal")
        {
            CanShot = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "boal")
        {
            CanShot = false;
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)&& CanShot==true)
        {
            TargetRigidbody.AddForceAtPosition(transform.forward * shootForce, transform.position);
            TargetRigidbody.AddForceAtPosition(transform.up * shootHeight, transform.position);


        }
    }
}




