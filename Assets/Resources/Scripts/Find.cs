using UnityEngine;
using System.Collections;

public class Find : MonoBehaviour {

    public GameObject foundObj;
    private GameObject nearest;
    private Target target;
    private GameObject temp;
    public bool enemy;

    //temp
    public void findNearestBase()
    {

            if (gameObject.tag == "Blue")
            {
            foundObj = GameObject.Find("Blue_Command");
            }
            if (gameObject.tag == "Red")
            {
            foundObj = GameObject.Find("Red_Command");
            }

    }
    //temp

    public void findNearest()
    {
        GameObject[] temp = null;
        if (enemy == true)
        {
            if (gameObject.tag == "Blue")
            {
                temp = GameObject.FindGameObjectsWithTag("Red");
            }
            if (gameObject.tag == "Red")
            {
                temp = GameObject.FindGameObjectsWithTag("Blue");
            }
        }
        else if (enemy == false)
        {
            if (gameObject.tag == "Blue")
            {
                temp = GameObject.FindGameObjectsWithTag("Blue");
            }
            if (gameObject.tag == "Red")
            {
                temp = GameObject.FindGameObjectsWithTag("Red");
            }
        }

        float distance = Mathf.Infinity;
            Vector2 position = transform.position;
            foreach (GameObject i in temp)
            {
                Vector2 diff = i.transform.position - transform.position;
                float curDistance = diff.sqrMagnitude;
                if (curDistance < distance)
                {
                    if (i != gameObject)
                    {
                        nearest = i;
                    }

                    distance = curDistance;
                }
            }
        foundObj = nearest;
        }
}
