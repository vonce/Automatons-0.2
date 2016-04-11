using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AttackRange : MonoBehaviour {


    private float attackRange;

    void Update()
    {
        if (attackRange != gameObject.GetComponentInParent<Status>().attackRange)
        {
            transform.localScale = new Vector2(gameObject.GetComponentInParent<Status>().attackRange, gameObject.GetComponentInParent<Status>().attackRange);
            attackRange = (gameObject.GetComponentInParent<Status>().attackRange);
        }
    }

    void OnTriggerEnter2D(Collider2D sight)
    {
        gameObject.GetComponentInParent<Status>().inAttackRange.Add(sight.gameObject.transform.parent.gameObject);
        AttackUpdate();
    }

    void OnTriggerExit2D(Collider2D notVisible)
    {
        gameObject.GetComponentInParent<Status>().inAttackRange.Remove(notVisible.gameObject.transform.parent.gameObject);
        AttackUpdate();
    }

    void AttackUpdate()
    {
        gameObject.GetComponentInParent<Status>().inAttackRange.RemoveWhere(GameObject => GameObject == null);
    }
}
