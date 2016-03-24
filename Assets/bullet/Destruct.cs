using UnityEngine;
using System.Collections;

public class Destruct : MonoBehaviour {

        void OnTriggerEnter2D()//trigger events
    {
            Destroy(gameObject);
    }
        void Update()
    {
        Destroy(gameObject, 2f);
    }
}
