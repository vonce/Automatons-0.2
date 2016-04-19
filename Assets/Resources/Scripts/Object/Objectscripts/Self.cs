using UnityEngine;
using System.Collections;

public class Self : MonoBehaviour, IObject
{
    public GameObject Object(Status status)
    {
        return gameObject;
    }
    public GameObject Object(Status status, SubOption subOption)
    {
        return gameObject;
    }
}
