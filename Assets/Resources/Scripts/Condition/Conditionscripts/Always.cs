using UnityEngine;
using System.Collections;
using System;

public class Always : MonoBehaviour, ICondition
{
    public ConditionE enumID()
    {
        return ConditionE.Always;
    }
    public bool Condition(GameObject target)
    {
        return true;
    }
    public bool Condition(GameObject target, SubOption subOption)
    {
        return true;
    }

}
