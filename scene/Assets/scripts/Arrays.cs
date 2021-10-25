using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public int[] arrayNumeros;
    private int suma = 1;
    public int numero = 6;
    // Start is called before the first frame update
    void Start()
    {

        //veces que se repite el numero 6
        if (numero == 6)
        {
            Debug.Log("Valor de numero =" + suma);
            suma = suma + 1;
        }

        for (int i = 0; i == 6; i++)
        {
            Debug.Log("contiene en la posicion" + i + "el valor" + arrayNumeros[i]);
            suma = suma + arrayNumeros[i];
            
        }
            Debug.Log(suma);

        // se vea el mayor numero

        if (numero > 10)
        {
            Debug.Log("mayor numero");
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
