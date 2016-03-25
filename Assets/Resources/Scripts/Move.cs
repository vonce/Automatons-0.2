using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

    private Target target;
    public float speed;

    void Awake () {
        target = GetComponent<Target>();
	}

	void Update () {
        if (target.sightRange > target.targetDistance && target.range < target.targetDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.targetVector, speed * Time.deltaTime);
        }
        //automatically moves towards target within range
    }
}
