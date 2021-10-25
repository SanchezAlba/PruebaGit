using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCOntroler : MonoBehaviour
{
    
    public GameObject futbolCrono;
    public GameObject jugarBalon;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    

    //menu crono
    public void ActivarFutbolCrono()
    {
        futbolCrono.SetActive(true);
    }

    public void DesactivarFutbolCrono()
    {
        futbolCrono.SetActive(false);
    }

   //menu temporizador
    public void ActivarJugarBalon()
    {
        jugarBalon.SetActive(true);
    }
    public void DesactivarJugarBalon()
    {
        jugarBalon.SetActive(false);
    }

   
}
