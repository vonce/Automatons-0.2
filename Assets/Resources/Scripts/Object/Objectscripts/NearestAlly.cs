using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NearestAlly : MonoBehaviour, IObject
{
    private List<GameObject> allyList;

    public GameObject Object(Status status)
    {
        allyList = new List<GameObject>();

        GameObject nearestEnemy = null;
        foreach (GameObject i in status.inSightRange)
        {
            if (i != null)
            {
                if (gameObject.tag == "Blue")
                {
                    if (i.tag == "Blue")
                    {
                        allyList.Add(i);
                    }
                }
                if (gameObject.tag == "Red")
                {
                    if (i.tag == "Red")
                    {
                        allyList.Add(i);
                    }
                }
            }
        }
        float distance = Mathf.Infinity;
        foreach (GameObject i in allyList)
        {
            Vector2 diff = i.transform.position - transform.position;
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
        allyList = new List<GameObject>();

        GameObject nearestEnemy = null;
        foreach (GameObject i in status.inSightRange)
        {
            if (i != null)
            {
                if (gameObject.tag == "Blue")
                {
                    if (i.tag == "Blue")
                    {
                        allyList.Add(i);
                    }
                }
                if (gameObject.tag == "Red")
                {
                    if (i.tag == "Blue")
                    {
                        allyList.Add(i);
                    }
                }
            }
        }

        float distance = Mathf.Infinity;
        foreach (GameObject i in allyList)
        {
            Vector2 diff = i.transform.position - transform.position;
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
