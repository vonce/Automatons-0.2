using UnityEngine;
using System.Collections;
using System;

public class Always : MonoBehaviour, ICondition
{
    public bool Condition(GameObject target)
    {
        return true;
    }
    public bool Condition(GameObject target, SubOption subOption)
    {
        return true;
    }

}
