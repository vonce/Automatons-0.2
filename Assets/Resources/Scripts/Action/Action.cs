using UnityEngine;
using System.Collections;

public interface IAction
{
    bool Action(GameObject target);
    bool Action(GameObject target, SubOption subOption);
}


