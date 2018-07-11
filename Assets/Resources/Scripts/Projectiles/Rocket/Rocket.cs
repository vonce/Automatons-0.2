using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public GameObject explosionPrefab;
    private GameObject explosion;
    private Vector3 startPosition;
    public GameObject target;
    private Vector3 direction;
    private Vector3 targetDirection;
    private Vector3 velocity;
    private float acceleration = .5f;
    public int rocketDamage;
    private float createTime;
    


    void Start()
    {
        createTime = Time.time;
        startPosition = transform.position;
        velocity = new Vector3(0, 4, 0);
    }

    void OnTriggerEnter(Collider other)//trigger events
    {
        explosion = Instantiate(explosionPrefab, gameObject.transform.position, Quaternion.identity) as GameObject;
        Destroy(gameObject);
    }


    void Update()
    {
        acceleration = 2f + acceleration;
        if (target != null)
        {
            targetDirection = (target.transform.position - transform.position).normalized;
        }
        velocity = velocity + (targetDirection * acceleration * Time.deltaTime);
        transform.position = transform.position + (velocity * Time.deltaTime);
        transform.rotation = Quaternion.LookRotation(velocity);
        
        Destroy(gameObject, 5f);
        startPosition = transform.position;
    }
}