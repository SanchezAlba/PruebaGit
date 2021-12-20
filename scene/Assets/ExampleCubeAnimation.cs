using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleCubeAnimation : MonoBehaviour
{
    private Animator cubeAnimator;

    private void Awake()
    {
        cubeAnimator = GetComponent<Animator>();   // esto es para que el cubo se quede rotanto quietito
        cubeAnimator.SetBool("idlle", true);
    }



    public void ExitIdlle()
    {
        cubeAnimator.SetBool("idlle", false);
    }

    public void Rrestart()
    {
        cubeAnimator.SetTrigger("restart");
        cubeAnimator.SetBool("idlle", true);
    }


    public void OnEnable()
    {
        
    }


}
