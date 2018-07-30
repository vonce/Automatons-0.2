using UnityEngine;
using System.Collections;

public interface IAction
{
    ActionE enumID();
    bool ActionCheck(GameObject target);
    void Action(GameObject target);
}


