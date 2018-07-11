using UnityEngine;
using System.Collections;

public class FaceFront : MonoBehaviour {

    private Vector3 facing;
    public float height;
    public float radius;

	void Update ()
    {
        gameObject.transform.localPosition = Face(gameObject.transform.parent.GetComponent<Status>().target);
    }

    Vector3 Face(GameObject target)
    {
        if (target != null)
        {
            facing = new Vector3(gameObject.transform.parent.transform.position.x - target.transform.position.x, 0, gameObject.transform.parent.transform.position.z - target.transform.position.z);
            facing = -facing.normalized * (radius/2 + 1);
            facing.y = height;
            gameObject.transform.parent.GetComponent<Status>().facing = facing;
            return facing;
        }
        else
        {
            return gameObject.transform.localPosition;
        }
    }
}
