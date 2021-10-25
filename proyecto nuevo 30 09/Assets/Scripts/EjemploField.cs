using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EjemploField : MonoBehaviour
{
    //InputField fieldNAme;  
    public TMP_InputField fieldTextMeshPro;

    public GameObject wellcomeScreen;
    public GameObject loginScreen;
    public TextMeshProUGUI nameTextLabel;

    //hay que crear otra pantalla

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("pro:" + fieldTextMeshPro.text);

    }

    public void clickLogiinButton()
    {
        loginScreen.SetActive(false);
        wellcomeScreen.SetActive(true);
        nameTextLabel.text = "hola" + fieldTextMeshPro.text;
;


    }
}
