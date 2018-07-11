using UnityEngine;
using System.Collections;

public class Heal : MonoBehaviour//, IAction
{
 /*   public bool Action(GameObject target)
    {
        return true;
    }
    public bool Action(GameObject target, SubOption subOption)
    {
        return true;
    }
    */
    public float healRate;
    public float healDistance;
    private GameObject[] team;
    private float nextHeal;

    void Update () {
        team = GameObject.FindGameObjectsWithTag(gameObject.tag);

        if (Time.time > nextHeal)
        {
            foreach (GameObject i in team)
            {
                Vector2 diff = i.transform.position - transform.position;
                float curDistance = diff.magnitude;
                if (curDistance < healDistance && i.GetComponent<Status>().currentHealth < i.GetComponent<Status>().maxHealth)
                {
                    if(i.GetComponent<Status>().maxHealth - i.GetComponent<Status>().currentHealth < 1)
                    {
                        i.GetComponent<Status>().currentHealth = i.GetComponent<Status>().maxHealth;
                    }
                    else
                    {
                        i.GetComponent<Status>().currentHealth = i.GetComponent<Status>().currentHealth + 3;
                    }
                    if (10 - i.GetComponent<Status>().currentSpecial < 5)
                    {
                        i.GetComponent<Status>().currentSpecial = 10;
                    }
                    else
                    {
                        i.GetComponent<Status>().currentSpecial = i.GetComponent<Status>().currentSpecial + 5;
                    }
                    nextHeal = Time.time + healRate;
                }
            }
        }
    }
}
