using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsManager : MonoBehaviour
{
    public static PointsManager instance;
    int amountPoints = 0;


    //static porque es igual para todos los elementos
    // Start is called before the first frame update
    // la awake se ejecuta antes quue el start
    void Awake()
        
    {
        if (PointsManager.instance == null)
        {
            PointsManager.instance = this;
        }

        else
        {
            Destroy(this);
        }
        
    }


    /// <summary>
    /// Añade puntos al jugador
    /// </summary>
    /// <param name="points">Puntos que se sumanal jugador</param>
    /// <returns></returns>
    public void AddPoints(int points)
    //añadir puntos a amountPoints
    {
        amountPoints = amountPoints + points;
        //otra forma amountPoints+=points;   
    
    
    }

    //una funcion (Get Points) que DEVUELVE la cantidad de puntos

     public int GetPoints()
    {
        return amountPoints;
    }
       



    // Update is called once per frame
    void Update()
    {
        
    }
}
