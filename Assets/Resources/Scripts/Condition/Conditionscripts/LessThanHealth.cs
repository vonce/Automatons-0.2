using UnityEngine;
using System.Collections;
using System;

public class LessThanHealth : MonoBehaviour, ICondition
{
    public int percentHealth;

    public bool Condition(GameObject target)
    {
        if (target.GetComponent<Status>().percentHealth < 50/*percentHealth*/)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
