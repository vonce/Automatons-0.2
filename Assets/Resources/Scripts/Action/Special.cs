using UnityEngine;
using System.Collections;

public class Special : MonoBehaviour{

    public Rigidbody2D rocketPrefab;
    public float fireRate;
    public Transform Front;
    private float nextFire;
    private Move move;
    Rigidbody2D rocket;
    private Target target;
    private Status status;
    private Vector2 rocketVector;

    void Awake()
    {
        target = GetComponent<Target>();
        status = GetComponent<Status>();
        move = GetComponent<Move>();
        nextFire = Time.time + fireRate;
    }

    void Update()
    {
        if (status.range < target.targetDistance)
        {
            move.MoveTo(target.target);
        }
        if (status.range > target.targetDistance && Time.time > nextFire && status.special >= 5)
        {
            rocketVector = gameObject.transform.position - target.target.transform.position;
            rocket = Instantiate(rocketPrefab, Front.position, Front.rotation) as Rigidbody2D;
            rocket.AddForce(rocketVector.normalized * -750, ForceMode2D.Force);

            status.special = status.special - 5;
        }
    }
}
