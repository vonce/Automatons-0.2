using UnityEngine;
using System.Collections;

public interface ICondition
{
    ConditionE enumID();
    bool Condition(GameObject target);
    bool Condition(GameObject target, SubOption subOption);
}
