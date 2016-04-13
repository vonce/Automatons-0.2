using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SightRange : MonoBehaviour {

    private float sightRange;
	
    void Update()
    {
        if (sightRange != gameObject.GetComponentInParent<Status>().sightRange)
        {
            transform.localScale = new Vector2(gameObject.GetComponentInParent<Status>().sightRange, gameObject.GetComponentInParent<Status>().sightRange);
            sightRange = (gameObject.GetComponentInParent<Status>().sightRange);
        }
    }

    void OnTriggerEnter2D(Collider2D sight)
    {
        print("ADD TO LIST");
        gameObject.GetComponentInParent<Status>().inSightRange.Add(sight.gameObject.transform.parent.gameObject);
        SightUpdate();
    }

    void OnTriggerExit2D(Collider2D notVisible)
    {
        print("REMOVE FROM LIST");
        gameObject.GetComponentInParent<Status>().inSightRange.Remove(notVisible.gameObject.transform.parent.gameObject);
        SightUpdate();
    }

    void SightUpdate()
    {       
        gameObject.GetComponentInParent<Status>().inSightRange.RemoveWhere(GameObject => GameObject == null);
        gameObject.GetComponentInParent<UnitBrain>().CheckLogicGate();
    }
}
