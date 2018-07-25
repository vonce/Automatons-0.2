using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Status : Health
{
    public LogicGate[] logicMatrix = new LogicGate[6];//create logic matrix
    public IAction action;//action gameObject is taking
    public GameObject target;//target of gameObject
    public HashSet<GameObject> inSightRange = new HashSet<GameObject>();//hashset of objects in sight range
    public HashSet<GameObject> inAttackRange = new HashSet<GameObject>();//hashset of objects in attack range
    public float attackRange;//attack range distance
    public float sightRange;//sight range distance
    public float speed;//speed
    public UnitTypeE unitType;//unit type enum
    public UnitBuildingE unitOrBuilding;//Identifies gameObject as unit or building
    public AttackTypeE attackType;//Type of attack
    public SpecialTypeE specialType;//Type of special
    public AuraTypeE auraType;//Type of aura
    public Vector3 facing;// vector3 of which direction unit is facing
    public bool aura = true;
    private float checkRate = .5f;
    private float nextCheck = .5f;

    void Start()
    {
        FullHealth();
        FullSpecial();
        if (unitOrBuilding == UnitBuildingE.Unit)
        {
            AddFromLogicMatrix();//add scripts from logic matrix
        }
    }

    void Update()
    {
        HealthCheck();
        SpecialCheck();
        if (unitOrBuilding == UnitBuildingE.Unit && Time.time > nextCheck)// && target == null)
        {
            nextCheck = Time.time + checkRate;
            gameObject.GetComponent<UnitBrain>().CheckLogicMatrix();
        }
    }

    void FixedUpdate()
    {
        if (unitOrBuilding == UnitBuildingE.Unit && target != null)
        {
            action.Action(target);
        }
    }

    void AddFromLogicMatrix()
    {
        int count = 0;
        foreach (LogicGate i in logicMatrix)
        {
            LogicGate logicGate = new LogicGate();

            if (gameObject.GetComponent(i.objectCondition.GetType()) == null)
            {
                gameObject.AddComponent(i.objectCondition.GetType());
            }
            logicGate.objectCondition = gameObject.GetComponent(i.objectCondition.GetType()) as IObject;
            logicGate.objectConditionSubOption = i.objectConditionSubOption;

            if (gameObject.GetComponent(i.condition.GetType()) == null)
            {
                gameObject.AddComponent(i.condition.GetType());
            }
            logicGate.condition = gameObject.GetComponent(i.condition.GetType()) as ICondition;
            logicGate.conditionSubOption = i.conditionSubOption;

            if (gameObject.GetComponent(i.action.GetType()) == null)
            {
                gameObject.AddComponent(i.action.GetType());
            }
            logicGate.action = gameObject.GetComponent(i.action.GetType()) as IAction;

            if (gameObject.GetComponent(i.objectAction.GetType()) == null)
            {
                gameObject.AddComponent(i.objectAction.GetType());
            }
            logicGate.objectAction = gameObject.GetComponent(i.objectAction.GetType()) as IObject;
            logicGate.objectActionSubOption = i.objectActionSubOption;

            logicMatrix[count] = logicGate;
            count++;
        }
    }
}
