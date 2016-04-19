using UnityEngine;
using System.Collections;

public class TESTSCRIPTDELETE : MonoBehaviour
{
    private LogicGate logicGate0 = new LogicGate();
    private LogicGate logicGate1 = new LogicGate();
    private LogicGate logicGate2 = new LogicGate();

    void Awake()
    {
        logicGate0.objectCondition = gameObject.AddComponent<Self>();
        logicGate0.condition = gameObject.AddComponent<LessThanHealth>();
        logicGate0.conditionSubOption.subOption = true;
        logicGate0.conditionSubOption.percent = 40;
        logicGate0.action = gameObject.AddComponent<Move>();
        logicGate0.objectAction = gameObject.AddComponent<AllyCommand>();

        logicGate1.objectCondition = gameObject.AddComponent<Self>();
        logicGate1.condition = gameObject.AddComponent<Always>();
        logicGate1.action = gameObject.AddComponent<Attack>();
        logicGate1.objectAction = gameObject.AddComponent<NearestEnemy>();

        logicGate2.objectCondition = gameObject.AddComponent<Self>();
        logicGate2.condition = gameObject.AddComponent<Always>();
        logicGate2.action = gameObject.AddComponent<Attack>();
        logicGate2.objectAction = gameObject.AddComponent<EnemyCommand>();

        gameObject.GetComponent<Status>().logicMatrix[0] = logicGate0;
        gameObject.GetComponent<Status>().logicMatrix[1] = logicGate1;
        gameObject.GetComponent<Status>().logicMatrix[2] = logicGate2;
    }
}
