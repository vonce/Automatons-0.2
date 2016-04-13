using UnityEngine;
using System.Collections;

public class LogicGate
{
    public IObject objectCondition;
    public ICondition condition;
    public IAction action;
    public IObject objectAction;

    public enum SubOptionE { optionalInt, optionalObject };

    public int percent;

    public void subOptionCheck ()
        {
            if (objectCondition == null)//IS A CONDITION NEEDING A SUBOPTION,MAKE LIST OF THEM;
            {
                
            }
        }

}
