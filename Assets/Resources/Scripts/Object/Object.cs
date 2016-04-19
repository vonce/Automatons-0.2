using UnityEngine;
using System.Collections;

public interface IObject
{
    GameObject Object(Status status);
    GameObject Object(Status status, SubOption subOption);
}

