using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

    public Rigidbody2D BulletPrefab;
    public float fireRate;
    public Transform Front;
    private float nextFire;
    Rigidbody2D Bullet;
    private Target target;
    private Status status;

    void Awake(){
        target = GetComponent<Target>();
        status = GetComponent<Status>();
        nextFire = Time.time + fireRate;
    }

    void Update(){
        if (status.range < target.targetDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.targetVector, status.speed * Time.deltaTime);
        }
        if (status.range > target.targetDistance && Time.time > nextFire)
        {
            Bullet = Instantiate(BulletPrefab, Front.position, Front.rotation) as Rigidbody2D;
            nextFire = Time.time + fireRate;
        }
    }
}
