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
    private GameObject[] temp;
    private float nextHeal;

    void Update () {
        if (gameObject.tag == "Red")
        {
            temp = GameObject.FindGameObjectsWithTag("Red");
        }
        if (gameObject.tag == "Blue")
        {
            temp = GameObject.FindGameObjectsWithTag("Blue");
        }
        if (Time.time > nextHeal)
        {
            foreach (GameObject i in temp)
            {
                Vector2 diff = i.transform.position - transform.position;
                float curDistance = diff.magnitude;
                if (curDistance < healDistance && i.GetComponent<Status>().currentHealth < i.GetComponent<Status>().maxHealth)
                {
                    if(i.GetComponent<Status>().maxHealth - i.GetComponent<Status>().currentHealth < 5)
                    {
                        i.GetComponent<Status>().currentHealth = i.GetComponent<Status>().maxHealth;
                    }
                    else
                    {
                        i.GetComponent<Status>().currentHealth = i.GetComponent<Status>().currentHealth + 5;
                    }
                    if (10 - i.GetComponent<Status>().special < 5)
                    {
                        i.GetComponent<Status>().special = 10;
                    }
                    else
                    {
                        i.GetComponent<Status>().special = i.GetComponent<Status>().special + 5;
                    }
                    nextHeal = Time.time + healRate;
                }
            }
        }
    }
}
