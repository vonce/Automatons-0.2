using UnityEngine;
using System.Collections;

public interface IAction
{
    bool Action(GameObject target);
}

/*OLD ACTION SCRIPT
public void ActionCheck(Action action)//takes status action and disables all scripts except script taken
    {
        DisableScript();        
        action.enabled = true;
    }



    //DISABLE SCRIPT-- disables all action scripts(non vital scripts)//
    void DisableScript()
    {
        MonoBehaviour[] scripts = gameObject.GetComponents<MonoBehaviour>();
        foreach (MonoBehaviour script in scripts)
        {
            if (script != gameObject.GetComponent<Status>() && script != gameObject.GetComponent<Action>())
                script.enabled = false;//turns off all scripts except vital
        }
    }
*/

