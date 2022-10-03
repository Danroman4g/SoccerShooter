using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boal : MonoBehaviour
{
    public GameController Controller;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Goal")
        {
            Debug.Log("GOOOAL");
            Controller.IncrementScore();



        }
    }
}
