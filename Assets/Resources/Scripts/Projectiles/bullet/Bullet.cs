using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
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
        if (other.gameObject.GetComponentInParent<Status>() != null)
        {
            other.gameObject.GetComponentInParent<Status>().currentHealth = other.gameObject.GetComponentInParent<Status>().currentHealth - 2;
            Destroy(gameObject);
        }
    }

    void Update()
    {
        Destroy(gameObject, 2f);
    }
}
