using UnityEngine;
using System.Collections;

public class FaceFront : MonoBehaviour {

    private Vector2 facing;

	void Update () {

        gameObject.transform.localPosition = Face(gameObject.transform.parent.GetComponent<Status>().target);

    }

    Vector2 Face(GameObject target)
    {
        if (target != null)
        {
            facing = new Vector2(gameObject.transform.parent.transform.position.x - target.transform.position.x, gameObject.transform.parent.transform.position.y - target.transform.position.y);
            facing = -facing.normalized;
            gameObject.transform.parent.GetComponent<Status>().facing = facing;
            facing.y = facing.y / 2;
            return facing;
        }
        else
        {
            return gameObject.transform.localPosition;
        }
    }
}
