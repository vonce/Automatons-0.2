using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SightRange : MonoBehaviour {

    private float sightRange;
    private Status status;
    private UnitBrain unitBrain;
    private Collider2D[] colliders;
    private float checkRate = .1f;
    private float nextCheck = .1f;

    void Start()
    {
        status = GetComponentInParent<Status>();
        unitBrain = GetComponentInParent<UnitBrain>();
    }

    void Update()
    {
        if(Time.time > nextCheck)
        {
            nextCheck = Time.time + checkRate;
            CheckSightRange();
        }
    }

    void CheckSightRange()
    {
        if (sightRange != status.sightRange)
        {
            transform.localScale = new Vector2(status.sightRange, status.sightRange);
            sightRange = (status.sightRange);
        }
        colliders = Physics2D.OverlapCircleAll(gameObject.transform.position, sightRange);

        GameObject[] sightRangeArray = new GameObject[colliders.Length];

        int j = 0;

        foreach (Collider2D i in colliders)
        {
            if (i.gameObject.transform.parent.gameObject != gameObject.transform.parent.gameObject)
            {
                sightRangeArray[j] = i.gameObject.transform.parent.gameObject;
                j++;
            }
        }
        status.inSightRange = new HashSet<GameObject>(sightRangeArray);  
    }
/*
    void OnTriggerEnter2D(Collider2D sight)
    {
        status.inSightRange.Add(sight.gameObject.transform.parent.gameObject);
        SightUpdate();
    }

    void OnTriggerExit2D(Collider2D notVisible)
    {
        status.inSightRange.Remove(notVisible.gameObject.transform.parent.gameObject);
        SightUpdate();
    }

    void SightUpdate()
    {
        status.inSightRange.RemoveWhere(GameObject => GameObject == null);
        //unitBrain.CheckLogicMatrix();
    }*/
}
