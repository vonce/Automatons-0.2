using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour {

    public Text blueMetalText;
    public Text redMetalText;
    public int blueMetal;
    public int redMetal;
    public CanvasRenderer button;
    public float dayLength;
    public CanvasRenderer panel;
    private float nextDay;
    private bool active;
    private bool team;
    private Color cl;
    GameObject[] allObjects;

	// Use this for initialization
	void Start ()
    {
        blueMetal = 100;
        redMetal = 100;
        blueMetalText.text = blueMetal.ToString();
        redMetalText.text = redMetal.ToString();
        cl = Color.black;
        panel.SetColor(cl);
        active = true;
        team = false;
        nextDay = Time.time;
        button.GetComponent<Button>().onClick.AddListener(playerControl);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Time.time >= nextDay && active == true)
        {
            allObjects = GameObject.FindObjectsOfType<GameObject>();
            foreach (GameObject obj in allObjects)
            {
                if (obj.GetComponent<Status>() != null)
                {
                    obj.GetComponent<Status>().active = false;
                }
            }
            cl = Color.blue;
            gameObject.tag = "Blue";
            panel.SetColor(cl);
            active = false;
            gameObject.GetComponent<Select>().selected = null;
        }
	}

    void playerControl()
    {
        if (cl == Color.red)
        {
            foreach (GameObject obj in allObjects)
            {
                if (obj != null && obj.GetComponent<Status>() != null)
                {
                    obj.GetComponent<Status>().active = true;
                }
            }
            cl = Color.black;
            gameObject.tag = "Untagged";
            panel.SetColor(cl);
            active = true;
            gameObject.GetComponent<Select>().selected = null;
            nextDay = Time.time + dayLength;
        }

        if (cl == Color.blue)
        {
            cl = Color.red;
            gameObject.tag = "Red";
            panel.SetColor(cl);
            gameObject.GetComponent<Select>().selected = null;
            team = true;
        }
    }
}
