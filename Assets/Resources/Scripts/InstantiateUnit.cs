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
        nextUnit = 10.0F;
        unitRate = 10.0F;
    }

    void Update()
    {
        if (Time.time > nextUnit)
        {
            nextUnit = Time.time + unitRate;
            Unit = Instantiate(UnitPrefab, Front.position, Front.rotation) as GameObject;
            Unit.GetComponent<UnitLogicArray>().logic = logicArray.logic;
        }
    }
}

