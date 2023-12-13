using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
[RequireComponent(typeof(TriggerDisplay))]
public class TriggerTeleportObject : MonoBehaviour
{
    public GameObject objectToTeleport;
    public Transform transformToTeleportObjectTo;
    public float teleportdelay = 0;

    //when player collides with this trigger
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //teleport object after said seconds
            Invoke("TeleportObject", teleportdelay);
        }
    }
    private void TeleportObject()
    {
        if (!transformToTeleportObjectTo || !objectToTeleport)
        {
            Debug.LogWarning("no references to teleport");
        }
        objectToTeleport.transform.position = transformToTeleportObjectTo.position;
        objectToTeleport.transform.rotation = transformToTeleportObjectTo.rotation;
    }
    //show where being teleported to
     void OnDrawGizmosSelected()
    {
        if (transformToTeleportObjectTo && objectToTeleport)
        {
            Debug.DrawLine(transformToTeleportObjectTo.position, objectToTeleport.transform.position);
        }
    }
}

