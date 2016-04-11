using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Status : Health
{

    public List<int[]> logicMatrix;
    public GameObject target;
    public IAction action;
    public HashSet<GameObject> inSightRange;
    public HashSet<GameObject> inAttackRange;
    public float special;
    public float attackRange;
    public float sightRange;
    public float speed;
    public UnitTypeE unitType;
    public Vector2 facing;

    void Start()
    {
        inAttackRange = new HashSet<GameObject>();
        inSightRange = new HashSet<GameObject>();
        logicMatrix = new List<int[]>();
        FullHealth();
    }

    void Update()
    {
        HealthCheck();
        if (target == null)
        {
            gameObject.GetComponent<UnitBrain>().CheckLogicGate();
        }
    }
}
