using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashDestroyer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "npc")
            Destroy(other.gameObject);
    }
}
