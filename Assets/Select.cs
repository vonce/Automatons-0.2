using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Select : MonoBehaviour {

    public Text selectedText;
    public GameObject selected;
    private GateDropdown gateDropdown;
    private int layermask;
	// Use this for initialization
	void Start () {
        layermask = 1 << 11;
        gateDropdown = GetComponent<GateDropdown>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetMouseButtonDown(0))
        {
            RaycastHit raycasthit = new RaycastHit();
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycasthit, Mathf.Infinity, layermask) == true)
            {
                Debug.Log(raycasthit.transform.gameObject);
                //if (raycasthit.transform.gameObject.GetComponent<Status>().unitType == UnitTypeE.Factory)
                //{
                    selected = raycasthit.transform.gameObject;

                    //gateDropdown.objectConditionDropdown0.value = selected.GetComponent<Status>().logicMatrix[0];

                    if (selected != null && selectedText != null)
                    {
                        selectedText.text = selected.name;
                    }
                //}
            }
        }
	}
}
