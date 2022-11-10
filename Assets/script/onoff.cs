using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onoff : MonoBehaviour
{
    public GameObject objectToActivateAndDesactivate;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            objectToActivateAndDesactivate.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            objectToActivateAndDesactivate.SetActive(true);
        }


    }
}
