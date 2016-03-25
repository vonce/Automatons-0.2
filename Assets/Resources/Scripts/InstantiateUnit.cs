using UnityEngine;
using System.Collections;

public class InstantiateUnit : MonoBehaviour
{

    public GameObject UnitPrefab;
    GameObject Unit;
    public Transform Front;
    private float nextUnit;
    private float unitRate;
    private LogicArray logicArray;

    void Awake()
    {
        logicArray = GetComponent<LogicArray>();
        nextUnit = 0.0F;
        unitRate = 10.0F;
    }

    void Update()
    {
        if (Time.time > nextUnit)
        {
            nextUnit = Time.time + unitRate;
            Unit = Instantiate(UnitPrefab, Front.position, Front.rotation) as GameObject;
            Unit.GetComponent<UnitLogicArray>().logic = new int[logicArray.rows , 5];
            Unit.GetComponent<UnitLogicArray>().rows = logicArray.rows;
            for (int i = 0; i < logicArray.rows; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Unit.GetComponent<UnitLogicArray>().logic[i,j] = logicArray.logic[i,j];
                }//passes logic array from BUILDING(LogicArray) to UNIT(UnitLogicArray)
            }
        }
    }
}

