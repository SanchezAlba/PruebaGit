using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador : MonoBehaviour
{
    // contar cuantas veces toco espacio, y al llegar  20 que ponga gané

    public int pressedTimes = 0;
    public float timer= 0.0f;
    public float maxTime = 5.0f;
    public int pressExpected=10;
    public bool resultsShowed = false;

    public slider slider;

    private void Start()
    {
        slider.maxValue = pressExpected;

    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;
        if (timer<=maxTime)
        {
            if (Input.GetKeyUp(KeyCode.Space) == true)
            {
                pressedTimes = pressedTimes + 1;
                //pressedTimes =+ 1
                //pressedTimes ++

                //hacer if si pulso 20 veces...

                slider.value = pressedTimes;
            }
        }
        else
        {
            
        }


       
        if (pressedTimes >= 20)
        {
            Debug.Log("Ganaste");
        }

        
        /*if(timer<=0)
        {
            Destroy(gameObject);
            Debug.Log("Se acabó el tiempo");
        }*/
    }


    public void ShowResulñts()
    {
        if(resultsShowed==false)
        {
            if (pressedTimes >= pressExpected)
            {
                resultsShowed = true;
            }

        }


    }
}
