 using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

    private Target target;
    private Status status;
    private Vector2 lastPos;

    void Awake ()
    {
        target = GetComponent<Target>();
        status = GetComponent<Status>();
    }

    void Update()
    {
        MoveTo(target.target);
    }

    public void MoveTo(GameObject moveTarget)
    {
        lastPos = transform.position;
        transform.position = Vector2.MoveTowards(transform.position, moveTarget.transform.position, status.speed * Time.deltaTime);
        //automatically moves towards target within range
        if (lastPos.x - transform.position.x > 0)
        {
            transform.localScale = new Vector2(-1, transform.localScale.y);
        }
        else
        {
            transform.localScale = new Vector2(1, transform.localScale.y);
        }
    }
}

