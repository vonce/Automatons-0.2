using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

    public Rigidbody2D BulletPrefab;
    public float fireRate;
    public Transform Front;
    private float nextFire;
    Rigidbody2D Bullet;
    private Target target;
    private Move move;

    void Awake(){
        target = GetComponent<Target>();
        move = GetComponent<Move>();
        nextFire = Time.time + fireRate;
    }

    void Update(){
        if (target.range > target.targetDistance && Time.time > nextFire){
            Bullet = Instantiate(BulletPrefab, Front.position, Front.rotation) as Rigidbody2D;
            nextFire = Time.time + fireRate;
        }
    }



}
