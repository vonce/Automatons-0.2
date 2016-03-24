using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {

    public GameObject target;
    public FindNearestEnemy findNearestEnemy;
    public Vector2 targetVector;
    public Vector2 unitVector;
    public float targetDistance;
    public float range;
    public float sightRange;

    void Awake()
    {
        findNearestEnemy = GetComponent<FindNearestEnemy>();
    }
    void Update()
    {

        target = findNearestEnemy.closest;
    }

    void FixedUpdate ()
    {
        Vector2 dir = target.transform.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        //faces target

        Vector2 temp = new Vector2(transform.position.x, transform.position.y);
        unitVector = temp;
        //stores coordinates of unit in "unitVector"

        Vector2 tempv = new Vector2(target.transform.position.x, target.transform.position.y);
        targetVector = tempv;
        //stores coordinates of target in "targetVector"

        float tempf = Vector2.Distance(targetVector, unitVector);
        targetDistance = tempf;
        //stores distance in "targetDistance"

    }
}
