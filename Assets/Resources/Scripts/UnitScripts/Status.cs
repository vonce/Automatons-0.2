using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Status : Health
{
    public LogicGate[] logicMatrix;//create logic matrix
    public IAction action;//action gameObject is taking
    public GameObject target;//target of gameObject
    public UnitBuildingE unitOrBuilding;//Identifies gameObject as unit or building
    public HashSet<GameObject> inSightRange;//hashset of objects in sight range
    public HashSet<GameObject> inAttackRange;//hashset of objects in attack range
    public float special;//amount of special
    public float attackRange;//attack range distance
    public float sightRange;//sight range distance
    public float speed;//speed 
    public UnitTypeE unitType;//unit type enum
    public Vector2 facing;// vector2 of which direction unit is facing
    public static int rows = 6;// number of rows for logic matrix

    private LogicGate logicGate;

    void Start()
    {
        inAttackRange = new HashSet<GameObject>();
        inSightRange = new HashSet<GameObject>();
        FullHealth();

        logicMatrix = new LogicGate[rows];

        foreach (LogicGate i in logicMatrix)
        {
            gameObject.AddComponent(i.objectCondition.GetType());
            gameObject.AddComponent(i.condition.GetType());
            gameObject.AddComponent(i.action.GetType());
            gameObject.AddComponent(i.objectAction.GetType());
        }
    }

    void Update()
    {
        foreach(GameObject i in inSightRange)
        {
            print(i);
        }

        HealthCheck();
        if (target == null)
        {
            gameObject.GetComponent<UnitBrain>().CheckLogicGate();
        }
        //print(action);
        action.Action(target); 
        //print(move);
    }
}
