using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Status : Health
{
    public LogicGate[] logicMatrix;
    public IAction action;
    public GameObject target;
    public UnitBuilding unitOrBuilding;
    public HashSet<GameObject> inSightRange;
    public HashSet<GameObject> inAttackRange;
    public float special;
    public float attackRange;
    public float sightRange;
    public float speed;
    public UnitTypeE unitType;
    public Vector2 facing;
    public static int rows = 6;

    private LogicGate logicGate;
    private Self self;
    private LessThanHealth lessThanHealth;
    private Move move;
    private NearestEnemy nearestEnemy;

    void Start()
    {
        inAttackRange = new HashSet<GameObject>();
        inSightRange = new HashSet<GameObject>();
        FullHealth();

        logicMatrix = new LogicGate[rows];
        logicGate = new LogicGate();
        self = gameObject.AddComponent<Self>();
        lessThanHealth = gameObject.AddComponent<LessThanHealth>();
        move = gameObject.AddComponent<Move>();
        nearestEnemy = gameObject.AddComponent<NearestEnemy>();
        logicMatrix[0] = logicGate;
        logicMatrix[0].myint = 1;

        

        logicMatrix[0].objectCondition = self;
        logicMatrix[0].condition = lessThanHealth;
        logicMatrix[0].action = move;
        logicMatrix[0].objectAction = nearestEnemy;

        
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
