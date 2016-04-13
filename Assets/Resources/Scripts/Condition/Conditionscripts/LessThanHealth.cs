using UnityEngine;
using System.Collections;
using System;

public class LessThanHealth : MonoBehaviour, ICondition
{
    public bool Condition(GameObject target)
    {
        if (target.GetComponent<Status>().percentHealth < 100)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool Condition(GameObject target, int percent)
    {
        if (target.GetComponent<Status>().percentHealth < percent)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
