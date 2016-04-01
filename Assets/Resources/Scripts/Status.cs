using UnityEngine;
using System.Collections;

public enum UnitType { Command, Factory, Unit1, Unit2 };
public enum Action { Attack, MoveTo, Special };

public class Status : Health {

    public GameObject target;
    public float special;
    public float range;
    public float sightRange;
    public float speed;
    public UnitType unitType;
    public Action action;

    void Start()
    {
        FullHealth();
    }

    void Update()
    {
        HealthCheck();
    }
}
