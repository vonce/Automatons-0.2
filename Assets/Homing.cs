using UnityEngine;
using System.Collections;

public class Homing : MonoBehaviour {

    private Target target;
    private Rigidbody2D rocket;
    public Transform Front;

    void Awake()
    {
        rocket = GetComponent<Rigidbody2D>();
        target = GetComponent<Target>();
    }

    void Start()
    {

    }

    void FixedUpdate ()
    {
        //accel towards target
    }
}
