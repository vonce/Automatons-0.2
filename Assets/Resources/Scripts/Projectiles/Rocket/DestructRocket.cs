using UnityEngine;
using System.Collections;

public class DestructRocket : MonoBehaviour
{
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
        other.gameObject.GetComponentInParent<Status>().currentHealth--;
        Destroy(gameObject);
    }

    void Update()
    {
        direction = -(transform.position - startPosition).normalized;

        Destroy(gameObject, 2f);
    }
}
