using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculadoraVelocidad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Velocidad=" + Velocidad(10.5f, 20.0f) + "m/s");

        //otra forma quitar para que funcione
        float v1 = Velocidad(10f, 20f);

        Debug.Log("Distancia=" + Distancia(14f,23f));

        Debug.Log("Tiempo=" + Tiempo(27f, 21f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //velocidad=espacio/tiempo v=d/t

    float Velocidad(float d, float t)
    {
        float v = d / t;
        return v;
    }

   //d=v*t
   float Distancia(float v,float t)
    {
        float d = v * t;
        return d;
    }

    // t=d/v
    float Tiempo(float d, float v)
    {
        float t = d / v;
        return t;
    }
        
}
