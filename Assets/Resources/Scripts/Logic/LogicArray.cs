using UnityEngine;
using System.Collections;

public class LogicArray : MonoBehaviour {

    public int[] logic;
    public enum Object : int {Self = 0, NearestEnemy = 1, NearestAlly = 2}; //enum for objects for logic matrix
    public Object obj;
    public enum Condition : int { Always = 0,  LessThanHealth = 1, MoreThanHealth = 2}; //enum for conditions for logic matrix
    public Condition cond;
    public int subCond;
    public Object objAct;
    public enum Action : int { Attack = 0, Flee = 1, Special = 2};//enum for actions for logic matrix
    public Action act;

    void Update()
    {
        logic[0] = (int)obj;
        logic[1] = (int)cond;
        logic[2] = subCond;
        logic[3] = (int)objAct;
        logic[4] = (int)act;
    }
}
