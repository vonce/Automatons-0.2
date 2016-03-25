using UnityEngine;
using System.Collections;

public class Heal : MonoBehaviour {

    public float healRate;
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
        float distance = 100;
        foreach (GameObject i in temp)
        {
            Vector2 diff = i.transform.position - transform.position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance && i.GetComponent<Health>().currentHealth < i.GetComponent<Health>().maxHealth && Time.time > nextHeal)
            {
                ++i.GetComponent<Health>().currentHealth;
                nextHeal = Time.time + healRate;
            }
        }

    }
}
