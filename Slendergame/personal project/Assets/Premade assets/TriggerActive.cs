using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(TriggerDisplay))]
public class TriggerActive : MonoBehaviour
{
    public GameObject objectToActivate;
    public float interactDelay = 0;

    //run when colliding with trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //make it run after seconds (interactdelay)
            Invoke("ActivateObject", interactDelay);

        }
    }
    private void ActivateObject()
    {
        objectToActivate.SetActive(true);
    }
}
