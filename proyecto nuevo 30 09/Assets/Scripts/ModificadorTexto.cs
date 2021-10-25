using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // tesh mesh pro


public class ModificadorTexto : MonoBehaviour
{
    public TextMeshProUGUI textLabelPoints;
    private int points = 0;
    public float time;


    // Start is called before the first frame update
    void Start()
    {
        //para cambiar el texto
        textLabelPoints.text = "probando...";

    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyUp(KeyCode.Space) == true)
         {
             points = points + 10;

             textLabelPoints.text = points.ToString();
         }

         // calcular tiempo

         time += Time.deltaTime;
         textLabelPoints.text = "tiempo en ejecucion " + time;*/



        // se cuente el tiempo cuando el espacio esta humdido

        if (Input.GetKey(KeyCode.Space) == true)
        {
            time += Time.deltaTime;
            textLabelPoints.text = "tiempo en ejecucion " + time;
        }


    }

}
