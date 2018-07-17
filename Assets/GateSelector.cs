using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateSelector : MonoBehaviour
{
    public ObjectE objectCondition0;
    public ConditionE condition0;
    public bool subOption0;
    public int subOptionPercent0;
    public ActionE action0;
    public ObjectE objectAction0;

    public ObjectE objectCondition1;
    public ConditionE condition1;
    public bool subOption1;
    public int subOptionPercent1;
    public ActionE action1;
    public ObjectE objectAction1;

    public ObjectE objectCondition2;
    public ConditionE condition2;
    public bool subOption2;
    public int subOptionPercent2;
    public ActionE action2;
    public ObjectE objectAction2;

    public ObjectE objectCondition3;
    public ConditionE condition3;
    public bool subOption3;
    public int subOptionPercent3;
    public ActionE action3;
    public ObjectE objectAction3;

    public ObjectE objectCondition4;
    public ConditionE condition4;
    public bool subOption4;
    public int subOptionPercent4;
    public ActionE action4;
    public ObjectE objectAction4;

    public ObjectE objectCondition5;
    public ConditionE condition5;
    public bool subOption5;
    public int subOptionPercent5;
    public ActionE action5;
    public ObjectE objectAction5;

    private LogicGate logicGate0 = new LogicGate();
    private LogicGate logicGate1 = new LogicGate();
    private LogicGate logicGate2 = new LogicGate();
    private LogicGate logicGate3 = new LogicGate();
    private LogicGate logicGate4 = new LogicGate();
    private LogicGate logicGate5 = new LogicGate();

    LogicGate Gate(ObjectE objectCondition, ConditionE condition, bool subOption, int subOptionPercent, ActionE action, ObjectE objectAction)
    {
        LogicGate tempGate = new LogicGate();

        if (objectCondition == ObjectE.AllyCommand) { tempGate.objectCondition = gameObject.AddComponent<AllyCommand>(); }//AllyCommand, EnemyCommand, LowestHealthEnemy, NearestAlly, NearestEnemy, Self
        if (objectCondition == ObjectE.EnemyCommand) { tempGate.objectCondition = gameObject.AddComponent<EnemyCommand>(); }
        if (objectCondition == ObjectE.LowestHealthEnemy) { tempGate.objectCondition = gameObject.AddComponent<LowestHealthEnemy>(); }
        if (objectCondition == ObjectE.NearestAlly) { tempGate.objectCondition = gameObject.AddComponent<NearestAlly>(); }
        if (objectCondition == ObjectE.NearestEnemy) { tempGate.objectCondition = gameObject.AddComponent<NearestEnemy>(); }
        if (objectCondition == ObjectE.Self) { tempGate.objectCondition = gameObject.AddComponent<Self>(); }

        if (condition == ConditionE.Always) { tempGate.condition = gameObject.AddComponent<Always>(); }//Always, LessThanHealth, MoreThanHealth
        if (condition == ConditionE.LessThanHealth) { tempGate.condition = gameObject.AddComponent<LessThanHealth>(); }
        if (condition == ConditionE.MoreThanHealth) { tempGate.condition = gameObject.AddComponent<MoreThanHealth>(); }

        tempGate.conditionSubOption.subOption = subOption;
        tempGate.conditionSubOption.percent = subOptionPercent;

        if (action == ActionE.Attack) { tempGate.action = gameObject.AddComponent<Attack>(); }//Attack, Move, Special 
        if (action == ActionE.Move) { tempGate.action = gameObject.AddComponent<Move>(); }
        if (action == ActionE.Special) { tempGate.action = gameObject.AddComponent<Special>(); }
        if (action == ActionE.Aura) { tempGate.action = gameObject.AddComponent<Aura>(); }

        if (objectAction == ObjectE.AllyCommand) { tempGate.objectAction = gameObject.AddComponent<AllyCommand>(); }//AllyCommand, EnemyCommand, LowestHealthEnemy, NearestAlly, NearestEnemy, Self
        if (objectAction == ObjectE.EnemyCommand) { tempGate.objectAction = gameObject.AddComponent<EnemyCommand>(); }
        if (objectAction == ObjectE.LowestHealthEnemy) { tempGate.objectAction = gameObject.AddComponent<LowestHealthEnemy>(); }
        if (objectAction == ObjectE.NearestAlly) { tempGate.objectAction = gameObject.AddComponent<NearestAlly>(); }
        if (objectAction == ObjectE.NearestEnemy) { tempGate.objectAction = gameObject.AddComponent<NearestEnemy>(); }
        if (objectAction == ObjectE.Self) { tempGate.objectAction = gameObject.AddComponent<Self>(); }

        return tempGate;
    }

    void Awake()
    {
        logicGate0 = Gate(objectCondition0, condition0, subOption0, subOptionPercent0, action0, objectAction0);
        logicGate1 = Gate(objectCondition1, condition1, subOption1, subOptionPercent1, action1, objectAction1);
        logicGate2 = Gate(objectCondition2, condition2, subOption2, subOptionPercent2, action2, objectAction2);
        logicGate3 = Gate(objectCondition3, condition3, subOption3, subOptionPercent3, action3, objectAction3);
        logicGate4 = Gate(objectCondition4, condition4, subOption4, subOptionPercent4, action4, objectAction4);
        logicGate5 = Gate(objectCondition5, condition5, subOption5, subOptionPercent5, action5, objectAction5);

        gameObject.GetComponent<Status>().logicMatrix[0] = logicGate0;
        gameObject.GetComponent<Status>().logicMatrix[1] = logicGate1;
        gameObject.GetComponent<Status>().logicMatrix[2] = logicGate2;
        gameObject.GetComponent<Status>().logicMatrix[3] = logicGate3;
        gameObject.GetComponent<Status>().logicMatrix[4] = logicGate4;
        gameObject.GetComponent<Status>().logicMatrix[5] = logicGate5;
    }
}
