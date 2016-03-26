using UnityEngine;
using System.Collections;

public class Heal : MonoBehaviour {

    public float healRate;
    private GameObject[] temp;
    private float nextHeal;

    float distance = 100;

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
                float curDistance = diff.sqrMagnitude;
                if (curDistance < distance && i.GetComponent<Health>().currentHealth < i.GetComponent<Health>().maxHealth)
                {
                    i.GetComponent<Health>().currentHealth = i.GetComponent<Health>().currentHealth + 5;
                    nextHeal = Time.time + healRate;
                }
            }
        }
    }
}
