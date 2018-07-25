using UnityEngine;
using System.Collections;

public class Special : MonoBehaviour, IAction
{
    public Rigidbody RocketPrefab;
    public Rigidbody EmpRocketPrefab;
    public float fireRate;
    public Transform Top;
    public Transform Front;
    public float projectileSpeed;
    private float nextFire;
    private Rigidbody rocket;
    private Rigidbody empRocket;
    private Status status;
    private Rocket rocketScript;
    private EmpRocket empRocketScript;
    private Vector3 rocketVector;
    private float targetDistance;
    private Vector3 beamVector;
    private Rigidbody healBeam;
    public Rigidbody BeamPrefab;


    void Awake()
    {
        status = GetComponent<Status>();
        nextFire = Time.time + fireRate;
    }

    public bool ActionCheck(GameObject target)
    {
        if (target != null && status.currentSpecial > 0)
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
        if ((target != null && status.currentSpecial > 0) && status.specialType == SpecialTypeE.Rocket)
        {

            targetDistance = Vector3.Distance(status.target.transform.position, transform.position);

            if (status.attackRange < targetDistance)
            {
                transform.position = Vector3.MoveTowards(transform.position, target.transform.position, status.speed * Time.deltaTime);
            }
            if (status.attackRange > targetDistance && Time.time > nextFire && status.specialType == SpecialTypeE.Rocket && status.currentSpecial >= 5)
            {
                rocketVector = Vector3.up;
                rocket = Instantiate(RocketPrefab, Top.position, Top.rotation) as Rigidbody;
                rocket.AddForce(rocketVector.normalized * projectileSpeed, ForceMode.Force);
                rocketScript = rocket.GetComponent<Rocket>();
                rocketScript.target = status.target;
                status.currentSpecial = status.currentSpecial - 5;
                nextFire = Time.time + fireRate;
            }
        }
        if ((target != null && status.currentSpecial > 0) && status.specialType == SpecialTypeE.HealBeam)
        {

            targetDistance = Vector3.Distance(status.target.transform.position, transform.position);

            if (status.attackRange < targetDistance)
            {
                transform.position = Vector3.MoveTowards(transform.position, target.transform.position, status.speed * Time.deltaTime);
            }
            if (status.attackRange > targetDistance && Time.time > nextFire && status.specialType == SpecialTypeE.HealBeam && status.currentSpecial >= 1)
            {
                beamVector = gameObject.transform.position - status.target.transform.position;
                if (healBeam == null)
                {
                    healBeam = Instantiate(BeamPrefab, Front.position, Quaternion.LookRotation(-beamVector)) as Rigidbody;
                    status.currentSpecial = status.currentSpecial - 1;
                }
            }
        }
        if ((target != null && status.currentSpecial > 0) && status.specialType == SpecialTypeE.Emp)
        {

            targetDistance = Vector3.Distance(status.target.transform.position, transform.position);

            if (status.attackRange < targetDistance)
            {
                transform.position = Vector3.MoveTowards(transform.position, target.transform.position, status.speed * Time.deltaTime);
            }
            if (status.attackRange > targetDistance && Time.time > nextFire && status.specialType == SpecialTypeE.Emp && status.currentSpecial >= 10)
            {
                rocketVector = Vector3.up;
                empRocket = Instantiate(EmpRocketPrefab, Top.position, Top.rotation) as Rigidbody;
                empRocket.AddForce(rocketVector.normalized * projectileSpeed, ForceMode.Force);
                empRocketScript = empRocket.GetComponent<EmpRocket>();
                empRocketScript.target = status.target;
                status.currentSpecial = status.currentSpecial - 10;
                nextFire = Time.time + fireRate;
            }
        }

    }
    void Update()
    {
        if (healBeam != null && gameObject != null && status.target != null && Quaternion.LookRotation(-(transform.position - status.target.transform.position)) != Quaternion.identity)
        {
            healBeam.position = Front.position;
            healBeam.rotation = Quaternion.LookRotation(-(transform.position - status.target.transform.position));
        }
    }
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
