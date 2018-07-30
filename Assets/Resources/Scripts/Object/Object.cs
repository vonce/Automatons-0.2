using UnityEngine;
using System.Collections;

public interface IObject
{
    ObjectE enumID();
    GameObject Object(Status status);
    GameObject Object(Status status, SubOption subOption);
}

