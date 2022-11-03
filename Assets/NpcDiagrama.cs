using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcDiagrama : MonoBehaviour
{
    [SerializeField] GameObject diagrama;
    [SerializeField] GameObject continuar;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            diagrama.SetActive(true);
            continuar.SetActive(true);
            other.gameObject.SetActive(false);
        }
    }
}
