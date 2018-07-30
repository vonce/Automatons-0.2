using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreThanHealth : MonoBehaviour, ICondition
{
    public ConditionE enumID()
    {
        return ConditionE.MoreThanHealth;
    }
    public bool Condition(GameObject target)
    {
        if (target != null && target.GetComponent<Status>().percentHealth > 50)
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
        if (target != null && target.GetComponent<Status>().percentHealth > subOption.percent)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
