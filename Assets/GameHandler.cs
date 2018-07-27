using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour {

    public CanvasRenderer button;
    public float dayLength;
    public CanvasRenderer panel;
    private float nextDay;
    private bool active;
    GameObject[] allObjects;

	// Use this for initialization
	void Start ()
    {
        panel.SetColor(Color.black);
        active = true;
        nextDay = Time.time + dayLength;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Time.time >= nextDay)
        {
            button.GetComponent<Button>().onClick.AddListener(playerControl);

            //panel.SetColor(Color.grey);
            
            active = false;
            allObjects = GameObject.FindObjectsOfType<GameObject>();
            foreach (GameObject obj in allObjects)
            {
                if (obj.GetComponent<Status>() != null)
                {
                    obj.GetComponent<Status>().active = false;
                }
            }
            panel.SetColor(Color.blue);
        }
	}

    void playerControl()
    {
        foreach (GameObject obj in allObjects)
        {
            if (obj.GetComponent<Status>() != null)
            {
                obj.GetComponent<Status>().active = true;
            }
        }
        panel.SetColor(Color.black);
        active = true;
        nextDay = Time.time + dayLength;
    }
}
