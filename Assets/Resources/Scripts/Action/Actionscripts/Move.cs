 using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour, IAction
{
    private Status status;
    private Vector2 lastPos;

    void Start()
    {
        status = GetComponent<Status>();
    }

    public bool Action(GameObject target)
    {
        if (target != null)
        {
            lastPos = transform.position;
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, status.speed * Time.deltaTime);
            return true;
            //automatically moves towards target within range
            //create sprite script based on FACING
        }
        else
        {
            return false;
        }
    }
    public bool Action(GameObject target, SubOption subOption)
    {
        if (target != null)
        {
            lastPos = transform.position;
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, status.speed * Time.deltaTime);
            return true;
            //automatically moves towards target within range
            //create sprite script based on FACING
        }
        else
        {
            return false;
        }
    }
}

