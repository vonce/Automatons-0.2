using UnityEngine;
using System.Collections;

public class UnitBrain : MonoBehaviour {

    public GameObject objectCondition;
    public GameObject objectAction;
    private Status status;
    private enum obj { self, nearestEnemy };
    private enum cond { always, hasLessHealth};
    private enum act { attack, moveTo};
    private IAction action;

    void Start()
    {
        status = GetComponent<Status>();
    }

    public void CheckLogicGate()
    {
        foreach(int[] i in status.logicMatrix)
        {
            if (CheckCondition(i[0], i[1], i[2]) == true)
            {
                if (CheckAction(i[3], i[4]) == true)
                {
                    Action(i[4]);
                }
                else
                {
                    
                }
            }
            else
            {
                
            }
        }
    }

    bool CheckCondition(int objCond, int cond, int subCond)
    {
        if (objCond == 1)
        {
            print("checkCondition OK");
            return true;
        }
        else
        {
            print("checkCondition fail");
            return false;
        }
    }

    bool CheckAction(int objAct, int act)
    {
        if (objAct == 4)
        {
            print("checkAct OK");
            return true;
        }
        else
        {
            print("checkAct FAIL");
            return false;
        }
    }

    void Action(int Act)
    {

    }
}
