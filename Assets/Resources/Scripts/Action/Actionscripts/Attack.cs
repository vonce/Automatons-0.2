using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour, IAction
{
    public ActionE actionEnum = ActionE.Attack;
    public Rigidbody BulletPrefab;
    public Rigidbody GrenadePrefab;
    public Rigidbody BeamPrefab;
    public float fireRate;
    public Transform Front;
    public float projectileSpeed;
    private float nextFire;
    Rigidbody bullet;
    Rigidbody grenade;
    Rigidbody beam;
    private Status status;
    private Vector3 bulletVector;
    private Vector3 grenadeVector;
    private Vector3 beamVector;
    private float vectorMag;
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
            if (status.attackRange >= targetDistance && Time.time > nextFire && status.attackType == AttackTypeE.Grenade)//Grenade attack
            {
                grenadeVector = -(gameObject.transform.position - status.target.transform.position)/2;
                grenadeVector += new Vector3(0, 9, 0);
                grenade = Instantiate(GrenadePrefab, Front.position, Front.rotation) as Rigidbody;
                grenade.velocity = grenadeVector;

                nextFire = Time.time + (fireRate) * 2;
            }

            if (status.attackRange >= targetDistance && Time.time > nextFire && status.attackType == AttackTypeE.Laser)//Laser attack
            {
                bulletVector = gameObject.transform.position - status.target.transform.position;
                bullet = Instantiate(BulletPrefab, Front.position, Quaternion.LookRotation(bulletVector)) as Rigidbody;
                bullet.AddForce(-bulletVector.normalized * projectileSpeed, ForceMode.Force);
                
                nextFire = Time.time + fireRate;
            }

            if (status.attackRange >= targetDistance && Time.time > nextFire && status.attackType == AttackTypeE.Beam)//Beam attack
            {
                beamVector = gameObject.transform.position - status.target.transform.position;
                if (beam == null)
                {
                    beam = Instantiate(BeamPrefab, Front.position, Quaternion.LookRotation(-beamVector)) as Rigidbody;
                }
            }
        }
    }
    void Update()
    {
        if (beam != null && gameObject != null && status.target != null && transform.position - status.target.transform.position != new Vector3(0,0,0))
        {
            beam.position = Front.position;
            beam.rotation = Quaternion.LookRotation(-(transform.position - status.target.transform.position));
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
