using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamColor : MonoBehaviour {

	void Start () {//Assigns color based on team tag. tags are used to differentiate teams
        Renderer renderer = GetComponent<Renderer>();
        if (transform.parent != null && transform.parent.tag == "Red")
        {
            renderer.material.color = Color.red;
        }
        if (transform.parent != null && transform.parent.tag == "Blue")
        {
            renderer.material.color = Color.blue;
        }
        if (transform.parent != null && transform.parent.tag == "Green")
        {
            renderer.material.color = Color.green;
        }
        if (transform.parent != null && transform.parent.tag == "Yellow")
        {
            renderer.material.color = Color.yellow;
        }
    }
}
