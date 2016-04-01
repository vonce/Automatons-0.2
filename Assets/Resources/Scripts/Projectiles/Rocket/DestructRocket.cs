using UnityEngine;
using System.Collections;

public class DestructRocket : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)//trigger events
    {
        other.gameObject.GetComponent<Status>().currentHealth = other.gameObject.GetComponent<Status>().currentHealth - 3;
        Destroy(gameObject);
    }
}
