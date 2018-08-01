using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour {

    public Plane plane;
    public Text blueMetalText;
    public Text redMetalText;
    public int blueMetal;
    public int redMetal;
    public GameObject factory;
    public GameObject refinery;
    private GameObject buildingPlaced;
    private GameObject building;
    public CanvasRenderer nextTurnButton;
    public CanvasRenderer buildFactoryButton;
    public CanvasRenderer buildRefineryButton;
    public float dayLength;
    public CanvasRenderer panel;
    private float nextDay;
    private bool active;
    private bool team;
    private Color cl;
    private int layermask = 1 << 13;
    private float dist;
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
        nextTurnButton.GetComponent<Button>().onClick.AddListener(playerControl);
        buildFactoryButton.GetComponent<Button>().onClick.AddListener(buildFactory);
        buildRefineryButton.GetComponent<Button>().onClick.AddListener(buildRefinery);
    }

    // Update is called once per frame
    void Update()
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

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit raycasthit = new RaycastHit();
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycasthit, Mathf.Infinity, layermask) == true && building != null)
            {
                if (gameObject.tag == "Blue" && blueMetal >= 50 && raycasthit.transform.gameObject.tag == "Blue")
                {
                    buildingPlaced = Instantiate(building, raycasthit.point, Quaternion.identity);
                    buildingPlaced.tag = "Blue";
                    blueMetal = blueMetal - 50;
                    blueMetalText.text = blueMetal.ToString();
                    building = null;
                }
                if (gameObject.tag == "Red" && redMetal >= 50 && raycasthit.transform.gameObject.tag == "Red")
                {
                    buildingPlaced = Instantiate(building, raycasthit.point, Quaternion.identity);
                    buildingPlaced.tag = "Red";
                    redMetal = redMetal - 50;
                    redMetalText.text = redMetal.ToString();
                    building = null;
                }
            }
        }
    }
    void buildFactory()
    {
        if (building == null || building == refinery)
        {
            building = factory;
        }
        else if (building == factory)
        {
            building = null;
        }
    }

    void buildRefinery()
    {
        if (building == null || building == factory)
        {
            building = refinery;
        }
        else if (building == refinery)
        {
            building = null;
        }
    }

    void playerControl()
    {
        if (cl == Color.red)
        {
            allObjects = GameObject.FindObjectsOfType<GameObject>();
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
