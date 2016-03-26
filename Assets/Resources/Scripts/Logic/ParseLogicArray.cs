using UnityEngine;
using System.Collections;

public class ParseLogicArray : MonoBehaviour {

	public GameObject objCond;
    public GameObject objAct;
    private Find find;
    private UnitLogicArray logicArray;
    private bool proceed;
    private int i;
    private float checkRate;
    private float nextCheck;

    void Start()
    {
        find = GetComponent<Find>();
        logicArray = GetComponent<UnitLogicArray>();

        MonoBehaviour[] scripts = gameObject.GetComponents<MonoBehaviour>();
        foreach (MonoBehaviour script in scripts)
        {
            if (script != find && script != logicArray && script != gameObject.GetComponent<ParseLogicArray>() && script != gameObject.GetComponent<Status>() && script != gameObject.GetComponent<Health>())
                script.enabled = false;//turns off all scripts except find, unit logic array, parse logic array, status, and health
        }
        i = 0;
        checkRate = 0.1f;
    }

    void Update()
    {
        if (Time.time > nextCheck)
        {
            Check();//checks conditions, returns true or false if fulfilled
            if (Check() == true)
            {
                Action();//Acts if conditions fulfilled
            }
            if (Check() == false)
            {
                i++;//put move to next row of logic matrix here
            }
            nextCheck = Time.time + checkRate;
        }
    }

/// <summary>
/// CHECKS CONDITION TO SEE IF ACTION CAN BE PERFORMED
/// </summary>

	bool Check () {
        proceed = false;
            if (logicArray.logic[i, 0] == 0)//set object(condition) to self
            {
                objCond = gameObject;
            }
            else if (logicArray.logic[i, 0] == 1)//set object(condition) to nearest enemy
            {
            find.enemy = true;
                find.findNearest();
                objCond = find.foundObj;
            }
            else if (logicArray.logic[i, 0] == 2)//set object(condition) to nearest ally
            {
                find.enemy = false;
                find.findNearest();
                objCond = find.foundObj;
            }

            if (logicArray.logic[i, 1] == 0)//return true always
            {
                proceed = true;
                return proceed;
            }
            else if (logicArray.logic[i, 1] == 1)//return true if object(condition) has less than set health
            {
                if (objCond.GetComponent<Health>().percentHealth < logicArray.logic[i, 2])
                {
                    proceed = true;
                    return proceed;

                }
            }
            else if (logicArray.logic[i, 1] == 2)//return true if object(condition) has more than set health
            {
                if (objCond.GetComponent<Health>().percentHealth > logicArray.logic[i, 2])
                {
                    proceed = true;
                    return proceed;
                }
            }
            else
            {
                proceed = false;
            }
        return proceed;
    }

    /// <summary>
    /// ACTION PERFORMED IF CHECK RETURNS TRUE, ALSO CHECKS IF ACTION CAN BE PERFORMED
    /// </summary>

    void Action()
    {
        if (logicArray.logic[i,3] == 0)//set object(action) to self
        {
            objAct = gameObject;
        }
        else if (logicArray.logic[i,3] == 1)//set object(action) to nearest enemy
        {
            find.enemy = true;
            find.findNearest();
            objAct = find.foundObj;
        }
        else if (logicArray.logic[i,3] == 2)//set object(action) to nearest ally
        {
            find.enemy = false;
            find.findNearest();
            objAct = find.foundObj;
        }
        else if (logicArray.logic[i, 3] == 3)//set object(action) to allied base
        {
            find.enemy = false;
            find.findNearestBase();
            objAct = find.foundObj;
        }
        else if (logicArray.logic[i, 3] == 4)//set object(action) to enemy base
        {
            find.enemy = true;
            find.findNearestBase();
            objAct = find.foundObj;
        }

        if (logicArray.logic[i,4] == 0)
        {
            gameObject.GetComponent<Target>().enabled = true;
            gameObject.GetComponent<Move>().enabled = false;
            gameObject.GetComponent<Attack>().enabled = true;
        }
        if (logicArray.logic[i,4] == 1)
        {
            gameObject.GetComponent<Target>().enabled = true;
            gameObject.GetComponent<Move>().enabled = true;
            gameObject.GetComponent<Attack>().enabled = false;
        }
        i = 0;
    }
}
