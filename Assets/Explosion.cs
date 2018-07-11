using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    Status status;
	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponentInParent<Status>() != null)
        {
            status = other.gameObject.GetComponentInParent<Status>();
            status.currentHealth = status.currentHealth - 3;
        }
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update () {
        Destroy(gameObject, .1f);
    }
}
