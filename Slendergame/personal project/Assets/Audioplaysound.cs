using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audioplaysound : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("teleported");

            source.PlayOneShot(clip);
        }
    }
}
