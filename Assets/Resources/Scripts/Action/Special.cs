using UnityEngine;
using System.Collections;

public class Special : MonoBehaviour{

    public Rigidbody2D RocketPrefab;
    public float fireRate;
    public Transform Front;
    private float nextFire;
    Rigidbody2D Rocket;
    private Target target;
    private Status status;

    void Awake()
    {
        target = GetComponent<Target>();
        status = GetComponent<Status>();
        nextFire = Time.time + fireRate;
    }

    void Update()
    {
        if (status.range < target.targetDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.targetVector, status.speed * Time.deltaTime);
        }
        if (status.range > target.targetDistance && Time.time > nextFire && status.special >= 5)
        {
            Rocket = Instantiate(RocketPrefab, Front.position, Front.rotation) as Rigidbody2D;
            nextFire = Time.time + fireRate;

            status.special = status.special - 5;
        }
    }
}
