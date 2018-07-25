using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aura : MonoBehaviour, IAction
{
    public GameObject damageAuraPrefab;
    public GameObject healAuraPrefab;
    private GameObject aura;
    private Status status;
    private float targetDistance;

    void Awake()
    {
        status = GetComponent<Status>();
    }

    public bool ActionCheck(GameObject target)
    {
        if (target != null && status.aura == true)
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
        if (status.attackRange >= targetDistance && status.auraType == AuraTypeE.DamageAura && aura == null)//damage aura
        {
            aura = Instantiate(damageAuraPrefab, gameObject.transform.position, Quaternion.identity) as GameObject;
        }

        if (status.attackRange >= targetDistance && status.auraType == AuraTypeE.HealAura && aura == null)//heal aura
        {
            aura = Instantiate(healAuraPrefab, gameObject.transform.position, Quaternion.identity) as GameObject;
        }

        if (status.attackRange >= targetDistance && status.attackType == AttackTypeE.Beam)
        {
            
        }
        status.aura = false;
    }

    void Update()
    {
        if (aura != null)
        {
            aura.transform.position = gameObject.transform.position;
        }
    }
}
