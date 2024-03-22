using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Drive better noob!");
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Package" && hasPackage == false)
        {
            Debug.Log("Package picked up!");
            hasPackage = true;
        } 
        else if(other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package dropped off!");
            hasPackage = false;
        }  
    }
}
