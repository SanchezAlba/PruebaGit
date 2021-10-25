using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialBucle : MonoBehaviour
{
    public GameObject cubePrefab;
    public int[] arrayNumeros;
    public int suma = 0;

    // Start is called before the first frame update
    void Start()
    {
        //for
        /*
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("Valor : " + i);

            Instantiate(cubePrefab, new Vector3(0.0f,10f*i, 5f * (i+1)), Quaternion.identity);
        }
        */

        // el num 10 es de los arrayNumeros que hemos añadido
        for (int i=0; i < 10; i++)
        {
            Debug.Log("contiene en la posicion" + i + "el valor" + arrayNumeros[i]);
            suma = suma + arrayNumeros[i];
        }
        Debug.Log(suma);
        



        //while
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
