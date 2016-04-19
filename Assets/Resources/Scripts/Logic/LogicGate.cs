using UnityEngine;
using System.Collections;

public struct LogicGate
{
    public IObject objectCondition;
    public SubOption objectConditionSubOption;
    public ICondition condition;
    public SubOption conditionSubOption;
    public IAction action;
    public SubOption actionSubOption;
    public IObject objectAction;
    public SubOption objectActionSubOption;
}