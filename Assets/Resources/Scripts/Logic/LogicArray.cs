using UnityEngine;
using System.Collections;

public class LogicArray : MonoBehaviour {

    public int[,] logic = new int[2, 5];
    public int rows;

    void Start()
    {

        logic[0, 0] = 0;//self
        logic[0, 1] = 1;//less than
        logic[0, 2] = 30;//30 percent
        logic[0, 3] = 3;//nearest base
        logic[0, 4] = 1;//flee

        logic[1, 0] = 1;//nearest enemy
        logic[1, 1] = 0;//always
        logic[1, 2] = 30;//30 percent
        logic[1, 3] = 1;//nearest base
        logic[1, 4] = 0;//attack
    }
    void Update()
    {

    }
}
