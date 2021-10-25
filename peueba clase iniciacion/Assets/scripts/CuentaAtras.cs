using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuentaAtras : MonoBehaviour
{
    public float timer = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;

        if (timer> 0.0f)
    {
            timer = timer - Time.deltaTime;
        }

        else
        {
            Destroy(gameObject);
        }

    }
}

    
