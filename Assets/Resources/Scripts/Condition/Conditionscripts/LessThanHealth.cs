using UnityEngine;
using System.Collections;
using System;

public class LessThanHealth : MonoBehaviour, ICondition
{
    public ConditionE conditionEnum = ConditionE.LessThanHealth;

    public bool Condition(GameObject target)
    {
        if (target != null && target.GetComponent<Status>().percentHealth < 50)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool Condition(GameObject target, SubOption subOption)
    {
        if (target != null && target.GetComponent<Status>().percentHealth < subOption.percent)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
