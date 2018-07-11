using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowestHealthEnemy : MonoBehaviour, IObject
{
    private List<GameObject> enemiesList;

    public GameObject Object(Status status)
    {
        enemiesList = new List<GameObject>();

        GameObject lowestHealthEnemy = null;
        foreach (GameObject i in status.inSightRange)
        {
            if (i != null)
            {
                if (gameObject.tag == "Blue")
                {
                    if (i.tag == "Red")
                    {
                        enemiesList.Add(i);
                    }
                }
                if (gameObject.tag == "Red")
                {
                    if (i.tag == "Blue")
                    {
                        enemiesList.Add(i);
                    }
                }
            }
        }
        float percentHealth = 100;
        foreach (GameObject i in enemiesList)
        {

            if (i.GetComponent<Status>().percentHealth <= percentHealth)
            {
                percentHealth = i.GetComponent<Status>().percentHealth;
                lowestHealthEnemy = i;
            }
        }
        return lowestHealthEnemy;
    }

    public GameObject Object(Status status, SubOption subOption)
    {
        enemiesList = new List<GameObject>();

        GameObject lowestHealthEnemy = null;
        foreach (GameObject i in status.inSightRange)
        {
            if (i != null)
            {
                if (gameObject.tag == "Blue")
                {
                    if (i.tag == "Red")
                    {
                        enemiesList.Add(i);
                    }
                }
                if (gameObject.tag == "Red")
                {
                    if (i.tag == "Blue")
                    {
                        enemiesList.Add(i);
                    }
                }
            }
        }
        float percentHealth = 100;
        foreach (GameObject i in enemiesList)
        {

            if (i.GetComponent<Status>().percentHealth <= percentHealth)
            {
                percentHealth = i.GetComponent<Status>().percentHealth;
                lowestHealthEnemy = i;
            }
        }
        return lowestHealthEnemy;
    }
}
