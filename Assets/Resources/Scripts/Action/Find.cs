using UnityEngine;
using System.Collections;

public class Find : MonoBehaviour {

    public bool enemy;
    public int unitType;
    private GameObject nearest;
    private Target target;
    private GameObject temp;

    public GameObject Nearest(bool enemy, int unitType)
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
                        if (unitType == -1)
                        {                            
                            nearest = i;
                            distance = curDistance;
                        }
                        else if(unitType == (int)i.GetComponent<Status>().unitType)
                        {
                            nearest = i;
                            distance = curDistance;
                        }
                        else
                        {
                            
                        }
                    }                    
                }
            }
        return nearest;
    }
}
