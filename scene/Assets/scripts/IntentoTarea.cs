using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntentoTarea : MonoBehaviour
{
    public int[] arrayNumeros;
    public int numeroRepetido = 6;
    public int numeroDeRepeticiones = 0;
    public int numeroMayor = 0;
    public int numeroMenor;
    // Start is called before the first frame update
    void Start()
    {
     for(int i=0; i<arrayNumeros.Length; i++ )
        {
            if (arrayNumeros[i] == numeroRepetido)
                numeroDeRepeticiones = numeroDeRepeticiones + 1;
        }
        if (numeroDeRepeticiones == 0)
            Debug.Log("no hay" + numeroRepetido);

        else if (numeroDeRepeticiones == 1)
            Debug.Log("solo hay un" + numeroRepetido);
        else
            Debug.Log("numero de" + numeroRepetido + "es" + numeroDeRepeticiones);

        //Para el numero mayor
        int numeroMayor = arrayNumeros[0];

        for (int i=1; i<arrayNumeros.Length; i++)
        {
            if (arrayNumeros[i] > numeroMayor)
                numeroMayor = arrayNumeros[i];
        }
        Debug.Log("el numero mayor es" + numeroMayor); //return mayor


        // Para el numero menor
        int numeroMenor()
        {//int numeroMenor = int.minValue;
           int numeroMenor = arrayNumeros[0];
            for (int i = 1; i < arrayNumeros.Length; i++)

            {
                if (arrayNumeros[i] < numeroMenor)
                {
                    numeroMenor = arrayNumeros[i];
                }

            }
            return numeroMenor;
            //Debug.Log("el numero menor es" + numeroMenor);
        }


       /* //Numero repetido
    public int numeroRepetido() //for(int i=1 porque el cero ya lo revisamos
        {
            int numeroRepetido = arrayNumeros[0];
            for(int i=0;i =arrayNumeros.Length;i++)
            {
                if(arrayNumeros == numeroRepetido)
                {

                }
            }
        }*/
            
    } 

    // Update is called once per frame
    void Update()
    {
        
    }
}
