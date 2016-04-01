using UnityEngine;
using System.Collections;

public class DestructBullet : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)//trigger events
    {
        other.gameObject.GetComponent<Status>().currentHealth--;
        Destroy(gameObject);

    }

    void Update()
    {
        Destroy(gameObject, 2f);
    }
}
