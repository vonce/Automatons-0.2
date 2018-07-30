using UnityEngine;
using System.Collections;

public class Self : MonoBehaviour, IObject
{
    public ObjectE enumID()
    {
        return ObjectE.Self;
    }
    public GameObject Object(Status status)
    {
        return gameObject;
    }
    public GameObject Object(Status status, SubOption subOption)
    {
        return gameObject;
    }
}
