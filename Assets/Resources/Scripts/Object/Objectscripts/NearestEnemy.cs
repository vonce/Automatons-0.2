using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NearestEnemy : MonoBehaviour, IObject
{
    private List<GameObject> enemiesList;

    public ObjectE enumID()
    {
        return ObjectE.NearestEnemy;
    }
    public GameObject Object(Status status)
    {
        enemiesList = new List<GameObject>();

        GameObject nearestEnemy = null;
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
        float distance = Mathf.Infinity;
        foreach (GameObject i in enemiesList)
        {
            Vector3 diff = i.transform.position - transform.position;
            float curDistance = diff.magnitude;            
            if (curDistance < distance)
            {
                distance = curDistance;
                nearestEnemy = i;
            }            
        }
        return nearestEnemy;
    }

    public GameObject Object(Status status, SubOption subOption)
    {
        enemiesList = new List<GameObject>();

        GameObject nearestEnemy = null;
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

        float distance = Mathf.Infinity;
        foreach (GameObject i in enemiesList)
        {
            Vector3 diff = i.transform.position - transform.position;
            float curDistance = diff.magnitude;
            if (curDistance < distance && i.GetComponent<Status>().unitType == subOption.unitType)
            {
                distance = curDistance;
                nearestEnemy = i;
            }
        }
        return nearestEnemy;
    }
}
