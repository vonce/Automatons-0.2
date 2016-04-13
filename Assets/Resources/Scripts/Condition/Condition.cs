using UnityEngine;
using System.Collections;

public interface ICondition
{
    bool Condition(GameObject target);
    bool Condition(GameObject target, int percent);
}
