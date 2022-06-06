using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class PopUpController : MonoBehaviour
{
    public static PopUpController instance;
    // Start is called before the first frame update
    void Start()
    {
        if(PopUpController.instance==false)
        {
            PopUpController.instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ShowPopUp()
    {
        gameObject.SetActive(true);

    }
}
