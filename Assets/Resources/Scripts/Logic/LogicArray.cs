using UnityEngine;
using System.Collections;

public class LogicArray : MonoBehaviour {

    public int rows;
    public int[,] logic;

    void Start()
    {
        logic = new int[rows, 5];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                logic[i, j] = 0;
            }
        }
        logic[0, 3] = 1;
    }
}

