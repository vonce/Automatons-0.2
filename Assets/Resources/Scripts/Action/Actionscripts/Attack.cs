using UnityEngine;
using System.Collections;

public class Attack : IAction
{
    public bool Action(GameObject target)
    {
        return true;
    }

    /*
        public Rigidbody2D BulletPrefab;
        public float fireRate;
        public Transform Front;
        public float projectileSpeed;
        private float nextFire;
        Rigidbody2D bullet;
        private Status status;
        private Move move;
        private Vector2 bulletVector;
        private float targetDistance;

        void Awake(){
            status = GetComponent<Status>();
            move = GetComponent<Move>();
            nextFire = Time.time + fireRate;
        }

        void Update(){
            targetDistance = Vector2.Distance(new Vector2(status.target.transform.position.x, (status.target.transform.position.y)*2), new Vector2(transform.position.x, (transform.position.y)*2));

            if (status.attackRange < targetDistance)
            {
                move.MoveTo(status.target);
            }
            if (status.attackRange > targetDistance && Time.time > nextFire)
            {
                bulletVector = gameObject.transform.position - status.target.transform.position;
                bullet = Instantiate(BulletPrefab, Front.position, Front.rotation) as Rigidbody2D;
                bullet.AddForce(-bulletVector.normalized * projectileSpeed, ForceMode2D.Force);

                nextFire = Time.time + fireRate;
            }
        }*/
}
