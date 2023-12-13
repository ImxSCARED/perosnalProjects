using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    public GameObject teleportNode;
    void OnTriggerEnter(Collider other)
    {
      if (other.tag == "Player")
        {
            Vector3 nodeLocation = teleportNode.transform.position;
            other.transform.position = nodeLocation;
            Quaternion nodeRotation = teleportNode.transform.rotation;
            other.transform.rotation = nodeRotation;
        }
    }

    private void OnDrawGizmos()
    {
        if (teleportNode)
        {
            Gizmos.color = Color.black;
            Gizmos.DrawLine(transform.position, teleportNode.transform.position);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
