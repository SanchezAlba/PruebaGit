using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JugarBalon : MonoBehaviour
{
    public TextMeshProUGUI labelTime;
    public float timer;
    public GameObject activarCrono;
    public bool activarTimer = true;
    public GameObject soltarBalon;

    // el resultado
    public GameObject gol;
    public GameObject pierdePelota;
    public GameObject falta;

    // Start is called before the first frame update
    void Start()
    {
        labelTime.text = gol.ToString();
        labelTime.text = pierdePelota.ToString();
        labelTime.text = falta.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        labelTime.text = timer.ToString();

       if(activarTimer==true)
        {
            timer = timer + Time.deltaTime;
        }
       /* else if(activarTimer == false)
        {
            timer = Time.deltaTime;
            
        }*/

      
    }


    public void ActivarCrono()
    {
        activarCrono.SetActive(true);
       
    }

    public void DesactivarCrono()
    {
        activarCrono.SetActive(false);
    }

    public void AtivarTimer()
    {
        timer += Time.deltaTime;
    }

    public void DesactivarTimer()
    { 
       
    }

    public void ActivarSoltarBalon()
    {
        soltarBalon.SetActive(true);
    }

    public void DesactivarSoltarBalon()
    {
        soltarBalon.SetActive(false);
        timer = Time.deltaTime;
    }

    // resultados

    public float GetDecimals(float number)
    {
        if (timer > 0 && timer <= 0.25)
        {
            gol.SetActive(true);
        }

       else if (timer > 0.26 && timer <= 0.80)
        {
            pierdePelota.SetActive(true);
        }

        else if (timer > 0.80 && timer <= 0.99)
        {
            falta.SetActive(true);
        }

        return number % 1;
    }

}

