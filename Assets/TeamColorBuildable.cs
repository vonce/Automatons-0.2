using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamColorBuildable : MonoBehaviour {

    private Color color;

    void Start()
    {//Assigns color based on team tag. tags are used to differentiate teams
        Renderer renderer = GetComponent<Renderer>();
        if (transform.parent != null && transform.parent.tag == "Red")
        {
            color = Color.red;
        }
        if (transform.parent != null && transform.parent.tag == "Blue")
        {
            color = Color.blue;
        }
        if (transform.parent != null && transform.parent.tag == "Green")
        {
            color = Color.green;
        }
        if (transform.parent != null && transform.parent.tag == "Yellow")
        {
            color = Color.yellow;
        }
        
        color.a = .25f;
        renderer.material.color = color;
    }

}
