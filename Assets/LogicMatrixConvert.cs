using UnityEngine;
using System.Collections;

public class LogicMatrixConvert : MonoBehaviour {

    void LogicMatrix()
    {
        foreach (LogicGate i in GetComponent<Status>().logicMatrix)
        {
            if (gameObject.GetComponent(i.objectCondition.GetType()) == null)
            {
                gameObject.AddComponent(i.objectCondition.GetType());
            }
            if (gameObject.GetComponent(i.condition.GetType()) == null)
            {
                gameObject.AddComponent(i.condition.GetType());
            }
            if (gameObject.GetComponent(i.action.GetType()) == null)
            {
                gameObject.AddComponent(i.action.GetType());
            }
                if (gameObject.GetComponent(i.objectAction.GetType()) == null)
            {
                gameObject.AddComponent(i.objectAction.GetType());
            }
        }
    }
}
