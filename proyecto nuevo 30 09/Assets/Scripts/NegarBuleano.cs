using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NegarBuleano : MonoBehaviour
{
    public bool isAlive=true;
    public TextMeshProUGUI label;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // que en el texto ponga true or false
        
        
    
        // que pase de true a false cuando toco espacio
       
        if (Input.GetKeyUp(KeyCode.Space) == true)
        {
            if (isAlive == true)
            {
                isAlive = false;
            }

            else
            {
                isAlive = true;
            }

            label.text = isAlive.ToString();
        }

       

        //otra forma isAlive=!isAlive;
    }


}
