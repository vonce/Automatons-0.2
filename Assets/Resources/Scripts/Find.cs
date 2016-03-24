using UnityEngine;
using System.Collections;

public class Find : MonoBehaviour {

    public GameObject nearest;
    private Target target;
    private GameObject temp;
    public bool enemy;

    void Awake ()
    {
        target = GetComponent<Target>();
    }

    void findNearest()
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

        float distance = target.sightRange;
            Vector2 position = transform.position;
            foreach (GameObject i in temp)
            {
                Vector2 diff = i.transform.position - transform.position;
                float curDistance = diff.sqrMagnitude;
                if (curDistance < distance)
                {
                    nearest = i;
                    distance = curDistance;
                }
            }
        }
}
