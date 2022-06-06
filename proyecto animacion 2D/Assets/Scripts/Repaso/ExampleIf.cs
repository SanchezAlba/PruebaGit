using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleIf : MonoBehaviour
{

    public Material materialRojo;
    public Material materialAzul;
    public MeshRenderer render;

    public float contador = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<MeshRenderer>(); //en el render no arrastro nada, pq tengo esta línea
        render.material = materialRojo;
    }

    // Update is called once per frame
    void Update()
    {
        contador += Time.deltaTime;

        if(contador>=5.0f)  // Cuando pasan 5s pasa de Rojo a Azul
        {
            render.material = materialAzul;

        }
    }
}
