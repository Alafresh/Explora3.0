using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashDestroyer : MonoBehaviour
{
    [SerializeField] int rangoMin;
    [SerializeField] int rangoMax;
    [SerializeField] GameObject[] npc;
    
    private void Start()
    {
        InvokeRepeating("CrearCaminante", rangoMin, rangoMax);
    }
    public void CrearCaminante()
    {
        int randomNpc = Random.Range(0, npc.Length);
        GameObject tmp = Instantiate(npc[randomNpc], transform.position, transform.rotation);
    }
}
