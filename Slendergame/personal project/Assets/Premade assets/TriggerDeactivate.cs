using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(TriggerDisplay))]
public class TriggerDeactivate : MonoBehaviour
{
    public GameObject objectToDeactivate;
    public float interactDelay = 0;

    //run when colliding with trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //make it stop run after seconds (interactdelay)
            Invoke("DeactivateObject", interactDelay);

        }
    }
    private void DeactivateObject()
    {
        objectToDeactivate.SetActive(false);
    }
}
