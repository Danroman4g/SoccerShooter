using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GK : MonoBehaviour
{
    public float speed = 2.5f;
    public float delta = 2f;
    private Vector3 startpos;

    private void Start()
    {
        startpos = transform.position;

    }
   
    void FixedUpdate()
    {
        Vector3 v = startpos;
        v.x += delta * Mathf.Sin (Time.time * speed);
        transform.position = v;

    }
}



/*   Или такая хуйня
  int maxValue = 15; // or whatever you want the max value to be
 int minValue = -15; // or whatever you want the min value to be
 int currentValue = 0; // or wherever you want to start
 int direction = 1; 
 
 Update() {
    currentValue += Time.deltaTime * direction; // or however you are incrementing the position
    if(currentValue >= maxValue) {
       direction *= -1;
       currentvalue = maxValue;
    } else if (currentValue <= minValue){
       direction *= -1; 
       currentvalue = minValue;
    }
    transform.position = new Vector3(currentValue, 0, 0);
 }
 */