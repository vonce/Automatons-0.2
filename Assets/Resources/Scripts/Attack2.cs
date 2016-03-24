using UnityEngine;
using System.Collections;

public class Attack2 : MonoBehaviour
{

    public Rigidbody2D RocketPrefab;
    public float fireRate;
    public Transform Left;
    public Transform Right;
    private float nextFire;
    Rigidbody2D Rocket;
    private Target target;
    private Move move;

    void Awake()
    {
        target = GetComponent<Target>();
        move = GetComponent<Move>();
        nextFire = 5.0F;
    }

    void Update()
    {
        if (target.range > target.targetDistance && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Rocket = Instantiate(RocketPrefab, Left.position, Left.rotation) as Rigidbody2D;
            Rocket.AddForce(Left.forward * 100);
            Rocket = Instantiate(RocketPrefab, Right.position, Right.rotation) as Rigidbody2D;
            Rocket.AddForce(Right.forward * 100);
        }
    }



}
