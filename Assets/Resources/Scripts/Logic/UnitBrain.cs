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
            if (i.condition.Condition(i.objectCondition.Object(status)) == false)
            {
                print("1");
            }
            else if (i.condition.Condition(i.objectCondition.Object(status)) == true)
            {
                print("2");

                if(i.action.Action(i.objectAction.Object(status)) == false)
                {
                    print("3");
                }
                else if (i.action.Action(i.objectAction.Object(status)) == true)
                {
                    print("4");
                    status.action = i.action;
                    status.target = i.objectAction.Object(status);
                    break;
                }
            }
        }
    }
}
