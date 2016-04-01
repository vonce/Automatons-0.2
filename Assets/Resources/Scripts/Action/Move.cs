 using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

    private Target target;
    private Status status;

    void Awake ()
    {
        target = GetComponent<Target>();
        status = GetComponent<Status>();
    }

	void Update () {
            transform.position = Vector2.MoveTowards(transform.position, target.targetVector, status.speed * Time.deltaTime);
        //automatically moves towards target within range
    }
}
