using UnityEngine;
using System.Collections;

public class DestructBullet : MonoBehaviour {

    void OnTriggerEnter(Collider other)//trigger events
    {
        other.gameObject.GetComponentInParent<Status>().currentHealth--;
        Destroy(gameObject);
    }

    void Update()
    {
        Destroy(gameObject, 2f);
    }
}
