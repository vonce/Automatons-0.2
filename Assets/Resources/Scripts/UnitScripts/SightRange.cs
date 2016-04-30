using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SightRange : MonoBehaviour {

    private float sightRange;
    private Status status;
    private UnitBrain unitBrain;
    private float checkRate = .1f;
    private float nextCheck = .1f;

    void Start()
    {
        status = GetComponentInParent<Status>();
        unitBrain = GetComponentInParent<UnitBrain>();
    }

    void Update()
    {
        if (sightRange != status.sightRange)
        {
            transform.localScale = new Vector2(status.sightRange, status.sightRange);
            sightRange = (status.sightRange);
        }
    }
/*    void CheckSightRange()
    {
        if (sightRange != status.sightRange)
        {
            transform.localScale = new Vector2(status.sightRange, status.sightRange);
            sightRange = (status.sightRange);
        }
        Collider2D[] colliders = Physics2D.OverlapCircleAll(gameObject.transform.position, sightRange);

        GameObject[] sightRangeArray = new GameObject[colliders.Length];


        foreach (Collider2D i in colliders)
        {
            int j = 0;
            if (i != null && i.gameObject.transform.parent.gameObject != gameObject.transform.parent.gameObject)
            {
                sightRangeArray[j] = i.gameObject.transform.parent.gameObject;
                j++;
            }
        }
        status.inSightRange = new HashSet<GameObject>(sightRangeArray);
        status.inSightRange.RemoveWhere(GameObject => GameObject == null);
    }
    */
    void OnTriggerEnter(Collider sight)
    {
        status.inSightRange.Add(sight.gameObject.transform.parent.gameObject);
        SightUpdate();
    }

    void OnTriggerExit(Collider notVisible)
    {
        status.inSightRange.Remove(notVisible.gameObject.transform.parent.gameObject);
        SightUpdate();
    }

    void SightUpdate()
    {
        status.inSightRange.RemoveWhere(GameObject => GameObject == null);
        //unitBrain.CheckLogicMatrix();
    }
}
