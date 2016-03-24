using UnityEngine;
using System.Collections;

public class UnitLogicArray : MonoBehaviour {

    public int[] logic;
    public enum Object : int { Self = 0, NearestEnemy = 1, NearestAlly = 2 }; //enum for objects for logic matrix
    public Object obj;
    public enum Condition : int { Always = 0, LessThanHealth = 1, MoreThanHealth = 2 }; //enum for conditions for logic matrix
    public Condition cond;
    public int subCond;
    public Object objAct;
    public enum Action : int { Attack = 0, Flee = 1, Special = 2 };//enum for actions for logic matrix
    public Action act;

    void Start()
    {
        obj = (Object)logic[0];
        cond = (Condition)logic[1];
        subCond = logic[2];
        objAct = (Object)logic[3];
        act = (Action)logic[4];
    }
}
