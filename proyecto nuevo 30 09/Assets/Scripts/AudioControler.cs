using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AudioControler : MonoBehaviour
{
    public Slider sliderSound; //para tener acceso al valor
    public AudioSource musicSource;
    public Slider sliderPitch;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SliderSoundModified()
    {
        Debug.Log("Valor modificado" + sliderSound.value);
        //EL volumen = slider sound value

        musicSource.volume = sliderSound.value;


    }
    // crear una funcion que al modificar el valor del slider de brillo/pitch cambia el pitch en el audio source

    public void SliderPitchModified()
    {
        musicSource.pitch = sliderSound.value;
    }
}
