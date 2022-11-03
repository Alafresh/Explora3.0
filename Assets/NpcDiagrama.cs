using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcDiagrama : MonoBehaviour
{
    [SerializeField] GameObject diagrama;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            diagrama.SetActive(true);
            other.gameObject.SetActive(false);
        }
    }
}
