using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControllers : MonoBehaviour
{
    public ExampleCubeAnimation[] cubeAnims;
    public GameObject[] cubes;

    public int index = 0;

    private void Awake()
    {
        for(int i=0;i< cubes.Length;i++)
        {
            if(i!=index)
            {
                cubes[i].SetActive(false);
            }

            else
            {
                cubes[i].SetActive(false);
            }
        }
    }

    public void NexCUbe()

    {
        cubeAnims[index].ExitIdlle();
        index++;

    }

}
