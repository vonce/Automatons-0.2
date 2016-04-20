using UnityEngine;
using System.Collections;

public class Special : MonoBehaviour, IAction
{
    public bool ActionCheck(GameObject target)
    {
        return true;
    }
    public void Action(GameObject target)
    {

    }

    /*
    public Rigidbody2D rocketPrefab;
    public float fireRate;
    public Transform Front;
    public float projectileSpeed;
    private float nextFire;
    private Move move;
    Rigidbody2D rocket;
    private Status status;
    private Vector2 rocketVector;
    private float targetDistance;

    void Awake()
    {
        status = GetComponent<Status>();
        move = GetComponent<Move>();
        nextFire = Time.time + fireRate;
    }

    void Update()
    {
        targetDistance = Vector2.Distance(new Vector2(status.target.transform.position.x, status.target.transform.position.y), new Vector2(transform.position.x, transform.position.y));
        if (status.sightRange < targetDistance)
        {
            move.MoveTo(status.target);
        }
        if (status.sightRange > targetDistance && Time.time > nextFire && status.special >= 5)
        {
            rocketVector = gameObject.transform.position - status.target.transform.position;
            rocket = Instantiate(rocketPrefab, Front.position, Front.rotation) as Rigidbody2D;
            rocket.AddForce(-rocketVector.normalized * projectileSpeed, ForceMode2D.Force);

            status.special = status.special - 5;
            nextFire = Time.time + fireRate;
        }
    }*/
}
