﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealAura : MonoBehaviour
{

    public float tick;
    private float nextTick;
    private List<Collider> inAura = new List<Collider>();


    // Use this for initialization
    void Start()
    {
        nextTick = Time.time + tick;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (inAura.Contains(other) != true && other.gameObject.GetComponentInParent<Status>() != null)
        {
            inAura.Add(other);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (inAura.Contains(other) == true)
        {
            inAura.Remove(other);
        }
    }

    void OnTriggerStay(Collider other)//trigger events
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (nextTick <= Time.time)
        {
            foreach (Collider col in inAura)
                if (col != null && col.gameObject.GetComponentInParent<Status>().currentHealth < col.gameObject.GetComponentInParent<Status>().maxHealth)
                {
                    col.GetComponentInParent<Status>().currentHealth++;
                }
            nextTick = Time.time + tick;
        }
        Destroy(gameObject, 5f);
    }
}
