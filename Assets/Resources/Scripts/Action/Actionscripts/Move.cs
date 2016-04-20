﻿ using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour, IAction
{
    private Status status;
    private Vector2 lastPos;

    void Start()
    {
        status = GetComponent<Status>();
    }

    public bool ActionCheck(GameObject target)
    {
        if (target != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Action(GameObject target)
    {
        if (target != null)
        {
            lastPos = transform.position;
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, status.speed * Time.deltaTime);
        }
    }
}

