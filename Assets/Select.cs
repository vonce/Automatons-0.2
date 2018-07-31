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
                //gateDropdown.delayTime = Time.time + .1f;
                //if (raycasthit.transform.gameObject.GetComponent<Status>().unitType == UnitTypeE.Factory)
                //{
                if (gameObject.tag == raycasthit.transform.gameObject.tag)
                {
                    selected = raycasthit.transform.gameObject;
                }
                

                if (selected.GetComponent<Status>().unitType == UnitTypeE.Factory && selected != null && selectedText != null)
                {
                    gateDropdown.delayTime = Time.time + .1f;
                    
                    selectedText.text = selected.name;

                    gateDropdown.attackTypeDropdown.value = (int)selected.GetComponent<Status>().attackType;
                    gateDropdown.specialTypeDropdown.value = (int)selected.GetComponent<Status>().specialType;
                    gateDropdown.auraTypeDropdown.value = (int)selected.GetComponent<Status>().auraType;

                    gateDropdown.objectConditionDropdown0.value = (int)selected.GetComponent<Status>().logicMatrix[0].objectCondition.enumID();
                    gateDropdown.objectConditionDropdown1.value = (int)selected.GetComponent<Status>().logicMatrix[1].objectCondition.enumID();
                    gateDropdown.objectConditionDropdown2.value = (int)selected.GetComponent<Status>().logicMatrix[2].objectCondition.enumID();
                    gateDropdown.objectConditionDropdown3.value = (int)selected.GetComponent<Status>().logicMatrix[3].objectCondition.enumID();
                    gateDropdown.objectConditionDropdown4.value = (int)selected.GetComponent<Status>().logicMatrix[4].objectCondition.enumID();

                    gateDropdown.conditionDropdown0.value = (int)selected.GetComponent<Status>().logicMatrix[0].condition.enumID();
                    gateDropdown.conditionDropdown1.value = (int)selected.GetComponent<Status>().logicMatrix[1].condition.enumID();
                    gateDropdown.conditionDropdown2.value = (int)selected.GetComponent<Status>().logicMatrix[2].condition.enumID();
                    gateDropdown.conditionDropdown3.value = (int)selected.GetComponent<Status>().logicMatrix[3].condition.enumID();
                    gateDropdown.conditionDropdown4.value = (int)selected.GetComponent<Status>().logicMatrix[4].condition.enumID();

                    gateDropdown.actionDropdown0.value = (int)selected.GetComponent<Status>().logicMatrix[0].action.enumID();
                    gateDropdown.actionDropdown1.value = (int)selected.GetComponent<Status>().logicMatrix[1].action.enumID();
                    gateDropdown.actionDropdown2.value = (int)selected.GetComponent<Status>().logicMatrix[2].action.enumID();
                    gateDropdown.actionDropdown3.value = (int)selected.GetComponent<Status>().logicMatrix[3].action.enumID();
                    gateDropdown.actionDropdown4.value = (int)selected.GetComponent<Status>().logicMatrix[4].action.enumID();

                    gateDropdown.objectActionDropdown0.value = (int)selected.GetComponent<Status>().logicMatrix[0].objectAction.enumID();
                    gateDropdown.objectActionDropdown1.value = (int)selected.GetComponent<Status>().logicMatrix[1].objectAction.enumID();
                    gateDropdown.objectActionDropdown2.value = (int)selected.GetComponent<Status>().logicMatrix[2].objectAction.enumID();
                    gateDropdown.objectActionDropdown3.value = (int)selected.GetComponent<Status>().logicMatrix[3].objectAction.enumID();
                    gateDropdown.objectActionDropdown4.value = (int)selected.GetComponent<Status>().logicMatrix[4].objectAction.enumID();
                }
            }
        }
	}
}
