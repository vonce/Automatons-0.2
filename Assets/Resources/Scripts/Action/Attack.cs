using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

    public Rigidbody2D BulletPrefab;
    public float fireRate;
    public Transform Front;
    private float nextFire;
    Rigidbody2D bullet;
    private Target target;
    private Status status;
    private Move move;
    private Vector2 bulletVector;

    void Awake(){
        target = GetComponent<Target>();
        status = GetComponent<Status>();
        move = GetComponent<Move>();
        nextFire = Time.time + fireRate;
    }

    void Update(){
        if (status.range < target.targetDistance)
        {
            move.MoveTo(target.target);
        }
        if (status.range > target.targetDistance && Time.time > nextFire)
        {
            bulletVector = gameObject.transform.position - target.target.transform.position;
            bullet = Instantiate(BulletPrefab, Front.position, Front.rotation) as Rigidbody2D;
            bullet.AddForce(bulletVector.normalized * -500, ForceMode2D.Force);

            nextFire = Time.time + fireRate;
        }
    }
}
