using UnityEngine;
using System.Collections;

public class ParseLogicArray : MonoBehaviour {

	private GameObject objCond;
    private GameObject objAct;
    private FindNearestEnemy findNearestEnemy;
    private UnitLogicArray logicArray;
    private int[] logic;
    private bool proceed;

    void Start()
    {
        findNearestEnemy = GetComponent<FindNearestEnemy>();
        logicArray = GetComponent<UnitLogicArray>();
        //GameObject findNearestEnemy = GetComponent<FindNearestEnemy>();
        proceed = false;
    }

    void Update()
    {
        Check();//checks conditions, returns true or false if fulfilled
        if (Check() == true)
        {
            Action();//Acts if conditions fulfilled
        }
    }

/// <summary>
/// CHECK
/// </summary>

	bool Check () {
        logic = logicArray.logic;
        if (logic[0] == 0)//set object(condition) to self
        {
            objCond = gameObject;
        }
        else if (logic[0] == 1)//set object(condition) to nearest enemy
        {
            objCond = findNearestEnemy.closest;
        }
        else if (logic[0] == 2)//set object(condition) to nearest ally
        {
            //objCond =
        }

        if (logic[1] == 0)//return true always
        {
            proceed = true;
            return proceed;
        }
        else if (logic[1] == 1)//return true if object(condition) has less than set health
        {
            proceed = true;
            return proceed;
        }
        else if (logic[1] == 2)//return true if object(condition) has more than set health
        {
            proceed = false;
            return proceed;
        }
        print(proceed);
        return proceed;
    }

/// <summary>
/// ACTION
/// </summary>

    void Action()
    {
        print("Action");
    }
}
