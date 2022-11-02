using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DestroyTime : MonoBehaviour
{
    float timer;
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 50)
        {
            Destroy(gameObject);
            timer = 0f;
        }
    }
}
