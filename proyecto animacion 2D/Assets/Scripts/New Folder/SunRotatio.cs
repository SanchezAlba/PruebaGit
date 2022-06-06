using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRotatio : MonoBehaviour
{
    // el script se lo pionemos al so, para que haga puesta sol
    public Vector3 rotation; //rottion es tipo float

    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.Rotate(rotation * Time.deltaTime);
    }
}
