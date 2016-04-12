using UnityEngine;
using System.Collections;

public class UnitBrain : MonoBehaviour {

    private Status status;

    void Start()
    {
        status = GetComponent<Status>();
    }

    public void CheckLogicGate()
    {
        print("check logic gate");
        foreach (LogicGate i in status.logicMatrix)
        {
            if (CheckCondition(i.objectCondition, i.condition) == false)
            {
                print("1");
            }
            if (CheckCondition(i.objectCondition, i.condition) == true)
            {
                print("2");

                if(CheckAction(i.objectAction, i.action) == false)
                {
                    print("3");
                }
                if (CheckAction(i.objectAction, i.action) == true)
                {
                    print("4");
                    status.action = i.action;
                    status.target = i.objectAction.Object(status);
                    break;
                }
            }

        }
    }

    bool CheckCondition(IObject objCond, ICondition cond)
    {
        return cond.Condition(objCond.Object(status));
    }

    bool CheckAction(IObject objAct, IAction act)
    {
        return act.Action(objAct.Object(status));
    }

}
