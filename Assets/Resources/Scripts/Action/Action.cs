using UnityEngine;
using System.Collections;

public interface IAction
{
    bool ActionCheck(GameObject target);
    void Action(GameObject target);

}


