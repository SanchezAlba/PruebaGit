using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControles : MonoBehaviour
{
    public static MenuControles instance;
    public GameObject pauseMenu;
    public GameObject optionsMenu;
    // Start is called before the first frame update
    void Awake()
    {
            if (instance == null)
            {
                instance = this;
            }

            else
            {
                Destroy(this);
            }
    }

    public void EnablePauseMenu()
    {
        pauseMenu.SetActive(true);
     }
        public void DisablePauseMenu()
    {
        pauseMenu.SetActive(false);
    }


    // para desactivar pause y activar opciones
    public void EnableSettingsMenu()
    {
        optionsMenu.SetActive(true);
    }
    
    public void DisableSettingsMenu()
    {
        optionsMenu.SetActive(false);
    }
}
    