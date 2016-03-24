using UnityEngine;
using System.Collections;

public class Forward : MonoBehaviour {

    public float speed;
    public Transform Front;

	void Update (){
        transform.position = Vector2.MoveTowards(transform.position, Front.position, speed * Time.deltaTime);
    }
}
