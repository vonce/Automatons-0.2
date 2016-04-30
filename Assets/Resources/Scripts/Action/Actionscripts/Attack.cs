using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour, IAction
{
    public Rigidbody BulletPrefab;
    public float fireRate;
    public Transform Front;
    public float projectileSpeed;
    private float nextFire;
    Rigidbody bullet;
    private Status status;
    private Vector3 bulletVector;
    private float targetDistance;

    void Awake()
    {
        status = GetComponent<Status>();
        nextFire = Time.time + fireRate;
    }

    public bool ActionCheck(GameObject target)
    {
        if (target != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void Action(GameObject target)
    {
        if (target != null)
        {
            targetDistance = Vector3.Distance(status.target.transform.position, transform.position);

            if (status.attackRange < targetDistance)
            {
                transform.position = Vector3.MoveTowards(transform.position, target.transform.position, status.speed * Time.deltaTime);
            }
            if (status.attackRange > targetDistance && Time.time > nextFire)
            {
                bulletVector = gameObject.transform.position - status.target.transform.position;
                bullet = Instantiate(BulletPrefab, Front.position, Front.rotation) as Rigidbody;
                bullet.AddForce(-bulletVector.normalized * projectileSpeed, ForceMode.Force);

                nextFire = Time.time + fireRate;
            }
        }
    }
}

    /*        

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
        }
        */
