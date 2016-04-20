using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AttackRange : MonoBehaviour {


    private float attackRange;
    private Status status;
    private UnitBrain unitBrain;
    private Collider2D[] colliders;
    private float checkRate = .1f;
    private float nextCheck = .1f;

    void Start()
    {
        status = GetComponentInParent<Status>();
        unitBrain = GetComponentInParent<UnitBrain>();
    }


    void Update()
    {
        if (Time.time > nextCheck)
        {
            nextCheck = Time.time + checkRate;
            CheckAttackRange();
        }
    }

    void CheckAttackRange()
    {
        if (attackRange != status.attackRange)
        {
            transform.localScale = new Vector2(status.attackRange, status.attackRange);
            attackRange = (status.attackRange);
        }
        colliders = Physics2D.OverlapCircleAll(gameObject.transform.position, attackRange);

        GameObject[] attackRangeArray = new GameObject[colliders.Length];

        int j = 0;
        
        foreach (Collider2D i in colliders)
        {
            if (i.gameObject.transform.parent.gameObject != gameObject.transform.parent.gameObject && i != null)
            {
                attackRangeArray[j] = i.gameObject.transform.parent.gameObject;
                j++;
            }
        }
        status.inAttackRange = new HashSet<GameObject>(attackRangeArray);
    }
/*
    void OnTriggerEnter2D(Collider2D sight)
    {
        status.inAttackRange.Add(sight.gameObject.transform.parent.gameObject);
        AttackUpdate();
    }

    void OnTriggerExit2D(Collider2D notVisible)
    {
        status.inAttackRange.Remove(notVisible.gameObject.transform.parent.gameObject);
        AttackUpdate();
    }

    void AttackUpdate()
    {
        status.inAttackRange.RemoveWhere(GameObject => GameObject == null);
        //unitBrain.CheckLogicMatrix();
    }
    */
}
