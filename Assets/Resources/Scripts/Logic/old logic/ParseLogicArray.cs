using UnityEngine;
using System.Collections;

public class ParseLogicArray : MonoBehaviour {
/*
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

		DisableScript ();
        i = 0;
        checkRate = 0.05f;
    }

    void Update()
    {
        //print(find.Nearest(true, 0));
        if (Time.time > nextCheck)
        {
            //Check();//checks conditions, returns true or false if fulfilled
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
                objCond = find.findObject(ConditionE.Nearest, true, UnitTypeE.Command);
            }
            else if (logicArray.logic[i, 0] == 2)//set object(condition) to nearest ally
            {
                objCond = find.findObject(ConditionE.Nearest, false, UnitTypeE.Command);
            }

            if (logicArray.logic[i, 1] == 0)//return true always
            {
                proceed = true;
                return proceed;
            }
            else if (logicArray.logic[i, 1] == 1)//return true if object(condition) has less than set health
            {
                if (objCond.GetComponent<Status>().percentHealth < logicArray.logic[i, 2])
                {
                    proceed = true;
                    return proceed;
                }
            }
            else if (logicArray.logic[i, 1] == 2)//return true if object(condition) has more than set health
            {
                if (objCond.GetComponent<Status>().percentHealth > logicArray.logic[i, 2])
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
            objAct = find.findObject(ConditionE.Nearest, true, UnitTypeE.Command);
        }
        else if (logicArray.logic[i,3] == 2)//set object(action) to nearest ally
        {
            objAct = find.findObject(ConditionE.Nearest, false, UnitTypeE.Command);
        }
        else if (logicArray.logic[i, 3] == 3)//set object(action) to allied base
        {
            objAct = find.findObject(ConditionE.Nearest, false, UnitTypeE.Command);
            print("asdf");
            print(find.findObject(ConditionE.Nearest, false, UnitTypeE.Command));
        }
        else if (logicArray.logic[i, 3] == 4)//set object(action) to enemy base
        {
            objAct = find.findObject(ConditionE.Nearest, true, UnitTypeE.Command);
        }

        if (logicArray.logic[i,4] == 0)
        {
			DisableScript ();
            gameObject.GetComponent<Target>().enabled = true;
            gameObject.GetComponent<Attack>().enabled = true;
        }
        if (logicArray.logic[i,4] == 1)
        {
			DisableScript ();
            gameObject.GetComponent<Target>().enabled = true;
            gameObject.GetComponent<Move>().enabled = true;
        }
        if (logicArray.logic[i, 4] == 2)
        {
			DisableScript ();
            gameObject.GetComponent<Target>().enabled = true;
            gameObject.GetComponent<Special>().enabled = true;
        }
        i = 0;
    }

	void DisableScript()
	{
		MonoBehaviour[] scripts = gameObject.GetComponents<MonoBehaviour>();
		foreach (MonoBehaviour script in scripts)
		{
			if (script != find && script != logicArray && script != gameObject.GetComponent<ParseLogicArray>() && script != gameObject.GetComponent<Status>() && script != gameObject.GetComponent<Target>())
				script.enabled = false;//turns off all scripts except find, unit logic array, parse logic array, status, health, and target
		}
	}
    */
}
