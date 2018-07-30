using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Refinery : MonoBehaviour {

    private GameObject canvas;
    public float tickRate;
    private float nextTick;

	// Use this for initialization
	void Start () {
        canvas = GameObject.Find("Canvas");
        nextTick = Time.time;
    }
	
	// Update is called once per frame
	void Update () {
		if (GetComponent<Status>().active == true && Time.time >= nextTick)
        {
            if (gameObject.tag == "Blue")
            {
                canvas.GetComponent<GameHandler>().blueMetal = canvas.GetComponent<GameHandler>().blueMetal + 5;
                canvas.GetComponent<GameHandler>().blueMetalText.text = canvas.GetComponent<GameHandler>().blueMetal.ToString();
            }
            if (gameObject.tag == "Red")
            {
                canvas.GetComponent<GameHandler>().redMetal = canvas.GetComponent<GameHandler>().redMetal + 5;
                canvas.GetComponent<GameHandler>().redMetalText.text = canvas.GetComponent<GameHandler>().redMetal.ToString();
            }
            nextTick = Time.time + tickRate;
        }
	}
}
