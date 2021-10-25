using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploAddsPoints : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space)==true) //up= cuando sueltas la tecla. Space es para la tacla espace
            {
            Debug.Log("Ha pulsado espacio");
            PointsManager.instance.AddPoints(10);
        }
    }
}
