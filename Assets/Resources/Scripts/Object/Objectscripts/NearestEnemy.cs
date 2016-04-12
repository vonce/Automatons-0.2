using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NearestEnemy : MonoBehaviour, IObject
{
    private List<GameObject> enemiesList;

    public GameObject Object(Status status)
    {
        enemiesList = new List<GameObject>();

        GameObject nearestEnemy = null;
        foreach (GameObject i in status.inSightRange)
        {
            if (gameObject.tag == "Blue")
            {
                if (i.tag == "Red")
                {
                    print(i);
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

        foreach (GameObject i in enemiesList)
        {
            float distance = status.sightRange;
            Vector2 diff = i.transform.position - transform.position;
            float curDistance = diff.magnitude;
            if (curDistance < distance)
            {
                nearestEnemy = i;
            }            
        }
        return nearestEnemy;
    }
}
