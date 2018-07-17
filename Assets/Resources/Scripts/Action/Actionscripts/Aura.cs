using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aura : MonoBehaviour, IAction
{
    public GameObject damageAuraPrefab;
    private GameObject damageAura;
    private Status status;
    private float targetDistance;

    void Awake()
    {
        status = GetComponent<Status>();
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
        targetDistance = Vector3.Distance(status.target.transform.position, transform.position);

        if (status.attackRange < targetDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, status.speed * Time.deltaTime);
        }
        if (status.attackRange >= targetDistance && damageAura == null)//Grenade attack
        {
            damageAura = Instantiate(damageAuraPrefab, gameObject.transform.position, Quaternion.identity) as GameObject;
        }

        if (status.attackRange >= targetDistance)//Laser attack
        {
            
        }

        if (status.attackRange >= targetDistance && status.attackType == AttackTypeE.Beam)//Beam attack
        {
            
        }
    }
    void Update()
    {
        if (damageAura != null)
        {
            damageAura.transform.position = gameObject.transform.position;
        }
    }
}
