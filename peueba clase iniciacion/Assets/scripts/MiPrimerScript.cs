using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiPrimerScript : MonoBehaviour
{
   public int numero = 8;
    // Start is called before the first frame update
    void Start()
    {

        ShowHealth();
        numero = numero + 5;
        ShowHealth();

        ShowHealth();
        numero = numero - 6;
        ShowHealth();

        ShowHealth();
        numero = numero * 5;

        ShowHealth();
        numero = (numero/4) + 4;
        
    }
    void ShowHealth()
    {
        Debug.Log("Valor de numero = " + numero);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
