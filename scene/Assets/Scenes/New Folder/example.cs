using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "SpaceShip", order = 1)]

public class example : ScriptableObject
{

    public string spaceshipName;
    [Range(0, 3.0f)]
    public int shield;
    [Range(0, 3.0f)]
    public int speed;
    [Range(0,3.0f)]
    public int heat;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
