using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlaySound : MonoBehaviour
{
    public AudioClip clip;
    public float interactDelay = 0;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            //run the statement
            Invoke("PlaySound", interactDelay);
        }
    }
    private void PlaySound()
    {
        //play the sound
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }
}
