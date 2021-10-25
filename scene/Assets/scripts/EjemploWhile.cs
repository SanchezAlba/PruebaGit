using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploWhile : MonoBehaviour
{
    public int repeticiones;
    public int maxRepeticiones;
    // Start is called before the first frame update
    void Start()
    {
        while (repeticiones < maxRepeticiones)
        {
            Debug.Log("texto que se repite");
            repeticiones++;
        }
        Debug.Log("texto que no se repite");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
