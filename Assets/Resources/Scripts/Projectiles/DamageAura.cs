using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageAura : MonoBehaviour {
    
    public float tick;
    private float nextTick;


    // Use this for initialization
    void Start ()
    {
        nextTick = Time.time + tick;
    }

    private void OnTriggerEnter(Collider other)
    {
        nextTick = Time.time + tick;
    }

    void OnTriggerStay(Collider other)//trigger events
    {
        if (other.gameObject.GetComponentInParent<Status>() != null)
        {
            if ((other.gameObject.GetComponentInParent<Status>().currentHealth < other.gameObject.GetComponentInParent<Status>().maxHealth))
            {
                other.gameObject.GetComponentInParent<Status>().currentHealth++;
            }   
            
        }
    }

    // Update is called once per frame
    void Update ()
    {

        Destroy(gameObject, 5f);

    }
}
