using UnityEngine;
using System.Collections;

public class FaceFront : MonoBehaviour {

    private Vector2 facing;

	void Update () {
        facing = new Vector2(gameObject.transform.parent.transform.position.x - gameObject.transform.parent.GetComponent<Status>().target.transform.position.x, gameObject.transform.parent.transform.position.y - gameObject.transform.parent.GetComponent<Status>().target.transform.position.y);
        facing = -facing.normalized;
        gameObject.transform.parent.GetComponent<Status>().facing = facing;
        facing.y = facing.y / 2;
        gameObject.transform.localPosition = facing;
    }
}
