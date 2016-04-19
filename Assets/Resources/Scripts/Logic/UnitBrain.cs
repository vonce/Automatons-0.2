using UnityEngine;
using System.Collections;

public class UnitBrain : MonoBehaviour {

    private Status status;
    private float nextCheck;
    private float checkRate;

    void Start()
    {
        status = GetComponent<Status>();
    }

    public void CheckLogicMatrix()
    {
        print("CHECK");
        foreach (LogicGate i in status.logicMatrix)
        {
            if (CheckCondition(i.objectCondition, i.condition, i.objectConditionSubOption, i.conditionSubOption) == false)
            {
                //print(i.objectCondition + " " + i.condition + " FALSE");
            }
            else if (CheckCondition(i.objectCondition, i.condition, i.objectConditionSubOption, i.conditionSubOption) == true)
            {
                //print(i.objectCondition + " " + i.condition + " TRUE");
                if (CheckAction(i.objectAction, i.action, i.objectActionSubOption, i.actionSubOption) == false)
                {
                    //print(i.objectAction + " " + i.action + " FALSE");
                }
                else if (CheckAction(i.objectAction, i.action, i.objectActionSubOption, i.actionSubOption) == true)
                {
                    //print(i.objectAction + " " + i.action + " TRUE");
                    status.action = i.action;
                    if (i.objectActionSubOption.subOption == true)
                    {
                        status.target = i.objectAction.Object(status, i.objectActionSubOption);
                    }
                    else
                    {
                        status.target = i.objectAction.Object(status);
                    }
                    break;
                }
            }
        }

    }
//Checks the OBJECTCONDITION against CONDITION with optional subOptions, returns bool
    private bool CheckCondition(IObject objectCondition, ICondition condition, SubOption objectConditionSubOption, SubOption conditionSubOption)
    {
        if (conditionSubOption.subOption == true)
        {
            if (objectConditionSubOption.subOption == true)
            {
                return condition.Condition(objectCondition.Object(status, objectConditionSubOption), conditionSubOption);
            }
            else
            {
                return condition.Condition(objectCondition.Object(status), conditionSubOption);
            }
        }
        else
        {
            if (objectConditionSubOption.subOption == true)
            {
                return condition.Condition(objectCondition.Object(status, objectConditionSubOption));
            }
            else
            {
                return condition.Condition(objectCondition.Object(status));
            }
        }        
    }

//Checks the OBJECTACTION against ACTION with optional subOptions, returns bool
    private bool CheckAction(IObject objectAction, IAction action, SubOption objectActionSubOption, SubOption actionSubOption)
    {
        if (actionSubOption.subOption == true)
        {
            if (objectActionSubOption.subOption == true)
            {
                return action.Action(objectAction.Object(status, objectActionSubOption), actionSubOption);
            }
            else
            {
                return action.Action(objectAction.Object(status), actionSubOption);
            }
        }
        else
        {
            if (objectActionSubOption.subOption == true)
            {
                return action.Action(objectAction.Object(status, objectActionSubOption));
            }
            else
            {
                return action.Action(objectAction.Object(status));
            }
        }
    }
}
