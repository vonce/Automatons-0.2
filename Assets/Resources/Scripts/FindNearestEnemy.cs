using UnityEngine;
using System.Collections;

public class FindNearestEnemy : MonoBehaviour {

    public GameObject closest;
    private GameObject nearest;



    void Update()
    {
            GameObject[] nearest = null;
            if (gameObject.tag == "Blue")
            {
                nearest = GameObject.FindGameObjectsWithTag("Red");
            }
            if (gameObject.tag == "Red")
            {
                nearest = GameObject.FindGameObjectsWithTag("Blue");
            }

            float distance = Mathf.Infinity;
            Vector2 position = transform.position;
            foreach (GameObject i in nearest)
            {
                Vector2 diff = i.transform.position - transform.position;
                float curDistance = diff.sqrMagnitude;
                if (curDistance < distance)
                {
                    closest = i;
                    distance = curDistance;
                }
            }
    }
}

