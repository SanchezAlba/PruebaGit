using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class condicional : MonoBehaviour
{
    public int edad = 11;
    // Start is called before the first frame update
    void Start()
    {
        if(edad>=18)
        {
            Debug.Log("Es mayor de edad, puede votar");

        }
        
        
        else
        {
            Debug.Log("Es mayor de edad, puede votar");
        }

        /*
         mayor igual 65 esta jubilado
        moyor de 18 y menor de 65
        menor de 18
         */

        if (edad>=65)
        {
            Debug.Log("esta jubilado");
           
        }
        else
        {
            Debug.Log(" no esta jubilado");
        }

        if (edad>18 && edad < 65)
        {
            Debug.Log("puede votar");
        }
        else
        {
            Debug.Log("no puede votar");
        }

        if(edad<18)
        {
            Debug.Log("no puede votar");
        }

        else
        {
            Debug.Log(" puede votar");
        }



        if (edad < 18)
        {
            Debug.Log("Es menor de edad");
        }
        else if (edad > 18 && edad < 35)
        {

            Debug.Log("Entre 18 y 35");
        }
        else if (edad > 35 && edad < 60)
        {

        }
        else
        {
            Debug.Log("lo que sea");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
