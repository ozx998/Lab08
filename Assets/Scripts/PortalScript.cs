using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    //
    public Transform Destination;
    

    //
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.position = Destination.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
