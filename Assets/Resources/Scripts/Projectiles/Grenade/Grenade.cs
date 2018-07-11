using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    public GameObject explosionPrefab;
    private GameObject explosion;
    private Vector3 startPosition;
    public Vector3 direction;
    private float createTime;

    void Start()
    {
        createTime = Time.time;
        startPosition = transform.position;
    }

    void OnTriggerEnter(Collider other)//trigger events
    {
        explosion = Instantiate(explosionPrefab, gameObject.transform.position, Quaternion.identity) as GameObject;
        Destroy(gameObject);
    }

    void Update()
    {
        direction = -(transform.position - startPosition).normalized;

        Destroy(gameObject, 5f);
    }
}

