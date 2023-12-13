using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerteleportSelf : MonoBehaviour
{
    public Transform transformToTeleportObjectTo;

    //when player collides with this trigger
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (!transformToTeleportObjectTo)
            {
                Debug.LogWarning("no reference for script");
            }
            //run the teleport, then deactivate the object after (delay) seconds
            other.transform.position = transformToTeleportObjectTo.position;
            other.transform.rotation = transformToTeleportObjectTo.rotation;
        }
    }



    //show where being teleported to 
    void OnDrawGizmosSelected()
    {
        if (transformToTeleportObjectTo)
        {
            Debug.DrawLine(transform.position, transformToTeleportObjectTo.transform.position);
        }
    }
}
