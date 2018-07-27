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
                selected = raycasthit.transform.gameObject;

                

                if (selected != null && selectedText != null)
                {
                    gateDropdown.delayTime = Time.time + .1f;
                    
                    selectedText.text = selected.name;
                    
                    if ((Object) selected.GetComponent<Status>().logicMatrix[0].objectCondition == selected.GetComponent<AllyCommand>()) { gateDropdown.objectConditionDropdown0.value = (int)ObjectE.AllyCommand; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[0].objectCondition == selected.GetComponent<EnemyCommand>()) { gateDropdown.objectConditionDropdown0.value = (int)ObjectE.EnemyCommand; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[0].objectCondition == selected.GetComponent<LowestHealthEnemy>()) { gateDropdown.objectConditionDropdown0.value = (int)ObjectE.LowestHealthEnemy; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[0].objectCondition == selected.GetComponent<NearestAlly>()) { gateDropdown.objectConditionDropdown0.value = (int)ObjectE.NearestAlly; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[0].objectCondition == selected.GetComponent<NearestEnemy>()) { gateDropdown.objectConditionDropdown0.value = (int)ObjectE.NearestEnemy; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[0].objectCondition == selected.GetComponent<Self>()) { gateDropdown.objectConditionDropdown0.value = (int)ObjectE.Self; }
                    
                    if ((Object) selected.GetComponent<Status>().logicMatrix[1].objectCondition == selected.GetComponent<AllyCommand>()) { gateDropdown.objectConditionDropdown1.value = (int)ObjectE.AllyCommand; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[1].objectCondition == selected.GetComponent<EnemyCommand>()) { gateDropdown.objectConditionDropdown1.value = (int)ObjectE.EnemyCommand; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[1].objectCondition == selected.GetComponent<LowestHealthEnemy>()) { gateDropdown.objectConditionDropdown1.value = (int)ObjectE.LowestHealthEnemy; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[1].objectCondition == selected.GetComponent<NearestAlly>()) { gateDropdown.objectConditionDropdown1.value = (int)ObjectE.NearestAlly; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[1].objectCondition == selected.GetComponent<NearestEnemy>()) { gateDropdown.objectConditionDropdown1.value = (int)ObjectE.NearestEnemy; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[1].objectCondition == selected.GetComponent<Self>()) { gateDropdown.objectConditionDropdown1.value = (int)ObjectE.Self; }
                    
                    if ((Object) selected.GetComponent<Status>().logicMatrix[2].objectCondition == selected.GetComponent<AllyCommand>()) { gateDropdown.objectConditionDropdown2.value = (int)ObjectE.AllyCommand; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[2].objectCondition == selected.GetComponent<EnemyCommand>()) { gateDropdown.objectConditionDropdown2.value = (int)ObjectE.EnemyCommand; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[2].objectCondition == selected.GetComponent<LowestHealthEnemy>()) { gateDropdown.objectConditionDropdown2.value = (int)ObjectE.LowestHealthEnemy; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[2].objectCondition == selected.GetComponent<NearestAlly>()) { gateDropdown.objectConditionDropdown2.value = (int)ObjectE.NearestAlly; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[2].objectCondition == selected.GetComponent<NearestEnemy>()) { gateDropdown.objectConditionDropdown2.value = (int)ObjectE.NearestEnemy; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[2].objectCondition == selected.GetComponent<Self>()) { gateDropdown.objectConditionDropdown2.value = (int)ObjectE.Self; }
                    
                    if ((Object) selected.GetComponent<Status>().logicMatrix[3].objectCondition == selected.GetComponent<AllyCommand>()) { gateDropdown.objectConditionDropdown3.value = (int)ObjectE.AllyCommand; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[3].objectCondition == selected.GetComponent<EnemyCommand>()) { gateDropdown.objectConditionDropdown3.value = (int)ObjectE.EnemyCommand; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[3].objectCondition == selected.GetComponent<LowestHealthEnemy>()) { gateDropdown.objectConditionDropdown3.value = (int)ObjectE.LowestHealthEnemy; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[3].objectCondition == selected.GetComponent<NearestAlly>()) { gateDropdown.objectConditionDropdown3.value = (int)ObjectE.NearestAlly; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[3].objectCondition == selected.GetComponent<NearestEnemy>()) { gateDropdown.objectConditionDropdown3.value = (int)ObjectE.NearestEnemy; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[3].objectCondition == selected.GetComponent<Self>()) { gateDropdown.objectConditionDropdown3.value = (int)ObjectE.Self; }
                    
                    if ((Object) selected.GetComponent<Status>().logicMatrix[4].objectCondition == selected.GetComponent<AllyCommand>()) { gateDropdown.objectConditionDropdown4.value = (int)ObjectE.AllyCommand; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[4].objectCondition == selected.GetComponent<EnemyCommand>()) { gateDropdown.objectConditionDropdown4.value = (int)ObjectE.EnemyCommand; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[4].objectCondition == selected.GetComponent<LowestHealthEnemy>()) { gateDropdown.objectConditionDropdown4.value = (int)ObjectE.LowestHealthEnemy; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[4].objectCondition == selected.GetComponent<NearestAlly>()) { gateDropdown.objectConditionDropdown4.value = (int)ObjectE.NearestAlly; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[4].objectCondition == selected.GetComponent<NearestEnemy>()) { gateDropdown.objectConditionDropdown4.value = (int)ObjectE.NearestEnemy; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[4].objectCondition == selected.GetComponent<Self>()) { gateDropdown.objectConditionDropdown4.value = (int)ObjectE.Self; }

                    if ((Object) selected.GetComponent<Status>().logicMatrix[0].condition == selected.GetComponent<Always>()) { gateDropdown.conditionDropdown0.value = (int)ConditionE.Always; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[0].condition == selected.GetComponent<LessThanHealth>()) { gateDropdown.conditionDropdown0.value = (int)ConditionE.LessThanHealth; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[0].condition == selected.GetComponent<MoreThanHealth>()) { gateDropdown.conditionDropdown0.value = (int)ConditionE.MoreThanHealth; }
                    
                    if ((Object) selected.GetComponent<Status>().logicMatrix[1].condition == selected.GetComponent<Always>()) { gateDropdown.conditionDropdown1.value = (int)ConditionE.Always; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[1].condition == selected.GetComponent<LessThanHealth>()) { gateDropdown.conditionDropdown1.value = (int)ConditionE.LessThanHealth; Debug.Log(selected.GetComponent<Status>().logicMatrix[1].condition); }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[1].condition == selected.GetComponent<MoreThanHealth>()) { gateDropdown.conditionDropdown1.value = (int)ConditionE.MoreThanHealth; }
                    
                    if ((Object) selected.GetComponent<Status>().logicMatrix[2].condition == selected.GetComponent<Always>()) { gateDropdown.conditionDropdown2.value = (int)ConditionE.Always; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[2].condition == selected.GetComponent<LessThanHealth>()) { gateDropdown.conditionDropdown2.value = (int)ConditionE.LessThanHealth; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[2].condition == selected.GetComponent<MoreThanHealth>()) { gateDropdown.conditionDropdown2.value = (int)ConditionE.MoreThanHealth; }
                    
                    if ((Object) selected.GetComponent<Status>().logicMatrix[3].condition == selected.GetComponent<Always>()) { gateDropdown.conditionDropdown3.value = (int)ConditionE.Always; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[3].condition == selected.GetComponent<LessThanHealth>()) { gateDropdown.conditionDropdown3.value = (int)ConditionE.LessThanHealth; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[3].condition == selected.GetComponent<MoreThanHealth>()) { gateDropdown.conditionDropdown3.value = (int)ConditionE.MoreThanHealth; }
                    
                    if ((Object) selected.GetComponent<Status>().logicMatrix[4].condition == selected.GetComponent<Always>()) { gateDropdown.conditionDropdown4.value = (int)ConditionE.Always; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[4].condition == selected.GetComponent<LessThanHealth>()) { gateDropdown.conditionDropdown4.value = (int)ConditionE.LessThanHealth; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[4].condition == selected.GetComponent<MoreThanHealth>()) { gateDropdown.conditionDropdown4.value = (int)ConditionE.MoreThanHealth; }
                    
                    if ((Object) selected.GetComponent<Status>().logicMatrix[0].action == selected.GetComponent<Attack>()) { gateDropdown.actionDropdown0.value = (int)ActionE.Attack; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[0].action == selected.GetComponent<Move>()) { gateDropdown.actionDropdown0.value = (int)ActionE.Move; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[0].action == selected.GetComponent<Special>()) { gateDropdown.actionDropdown0.value = (int)ActionE.Special; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[0].action == selected.GetComponent<Aura>()) { gateDropdown.actionDropdown0.value = (int)ActionE.Aura; }

                    if ((Object) selected.GetComponent<Status>().logicMatrix[1].action == selected.GetComponent<Attack>()) { gateDropdown.actionDropdown1.value = (int)ActionE.Attack; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[1].action == selected.GetComponent<Move>()) { gateDropdown.actionDropdown1.value = (int)ActionE.Move; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[1].action == selected.GetComponent<Special>()) { gateDropdown.actionDropdown1.value = (int)ActionE.Special; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[1].action == selected.GetComponent<Aura>()) { gateDropdown.actionDropdown1.value = (int)ActionE.Aura; }

                    if ((Object) selected.GetComponent<Status>().logicMatrix[2].action == selected.GetComponent<Attack>()) { gateDropdown.actionDropdown2.value = (int)ActionE.Attack; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[2].action == selected.GetComponent<Move>()) { gateDropdown.actionDropdown2.value = (int)ActionE.Move; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[2].action == selected.GetComponent<Special>()) { gateDropdown.actionDropdown2.value = (int)ActionE.Special; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[2].action == selected.GetComponent<Aura>()) { gateDropdown.actionDropdown2.value = (int)ActionE.Aura; }

                    if ((Object) selected.GetComponent<Status>().logicMatrix[3].action == selected.GetComponent<Attack>()) { gateDropdown.actionDropdown3.value = (int)ActionE.Attack; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[3].action == selected.GetComponent<Move>()) { gateDropdown.actionDropdown3.value = (int)ActionE.Move; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[3].action == selected.GetComponent<Special>()) { gateDropdown.actionDropdown3.value = (int)ActionE.Special; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[3].action == selected.GetComponent<Aura>()) { gateDropdown.actionDropdown3.value = (int)ActionE.Aura; }

                    if ((Object) selected.GetComponent<Status>().logicMatrix[4].action == selected.GetComponent<Attack>()) { gateDropdown.actionDropdown4.value = (int)ActionE.Attack; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[4].action == selected.GetComponent<Move>()) { gateDropdown.actionDropdown4.value = (int)ActionE.Move; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[4].action == selected.GetComponent<Special>()) { gateDropdown.actionDropdown4.value = (int)ActionE.Special; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[4].action == selected.GetComponent<Aura>()) { gateDropdown.actionDropdown4.value = (int)ActionE.Aura; }

                    if ((Object) selected.GetComponent<Status>().logicMatrix[0].objectAction == selected.GetComponent<AllyCommand>()) { gateDropdown.objectActionDropdown0.value = (int)ObjectE.AllyCommand; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[0].objectAction == selected.GetComponent<EnemyCommand>()) { gateDropdown.objectActionDropdown0.value = (int)ObjectE.EnemyCommand; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[0].objectAction == selected.GetComponent<LowestHealthEnemy>()) { gateDropdown.objectActionDropdown0.value = (int)ObjectE.LowestHealthEnemy; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[0].objectAction == selected.GetComponent<NearestAlly>()) { gateDropdown.objectActionDropdown0.value = (int)ObjectE.NearestAlly; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[0].objectAction == selected.GetComponent<NearestEnemy>()) { gateDropdown.objectActionDropdown0.value = (int)ObjectE.NearestEnemy; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[0].objectAction == selected.GetComponent<Self>()) { gateDropdown.objectActionDropdown0.value = (int)ObjectE.Self; }

                    if ((Object) selected.GetComponent<Status>().logicMatrix[1].objectAction == selected.GetComponent<AllyCommand>()) { gateDropdown.objectActionDropdown1.value = (int)ObjectE.AllyCommand; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[1].objectAction == selected.GetComponent<EnemyCommand>()) { gateDropdown.objectActionDropdown1.value = (int)ObjectE.EnemyCommand; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[1].objectAction == selected.GetComponent<LowestHealthEnemy>()) { gateDropdown.objectActionDropdown1.value = (int)ObjectE.LowestHealthEnemy; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[1].objectAction == selected.GetComponent<NearestAlly>()) { gateDropdown.objectActionDropdown1.value = (int)ObjectE.NearestAlly; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[1].objectAction == selected.GetComponent<NearestEnemy>()) { gateDropdown.objectActionDropdown1.value = (int)ObjectE.NearestEnemy; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[1].objectAction == selected.GetComponent<Self>()) { gateDropdown.objectActionDropdown1.value = (int)ObjectE.Self; }

                    if ((Object) selected.GetComponent<Status>().logicMatrix[2].objectAction == selected.GetComponent<AllyCommand>()) { gateDropdown.objectActionDropdown2.value = (int)ObjectE.AllyCommand; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[2].objectAction == selected.GetComponent<EnemyCommand>()) { gateDropdown.objectActionDropdown2.value = (int)ObjectE.EnemyCommand; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[2].objectAction == selected.GetComponent<LowestHealthEnemy>()) { gateDropdown.objectActionDropdown2.value = (int)ObjectE.LowestHealthEnemy; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[2].objectAction == selected.GetComponent<NearestAlly>()) { gateDropdown.objectActionDropdown2.value = (int)ObjectE.NearestAlly; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[2].objectAction == selected.GetComponent<NearestEnemy>()) { gateDropdown.objectActionDropdown2.value = (int)ObjectE.NearestEnemy; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[2].objectAction == selected.GetComponent<Self>()) { gateDropdown.objectActionDropdown2.value = (int)ObjectE.Self; }

                    if ((Object) selected.GetComponent<Status>().logicMatrix[3].objectAction == selected.GetComponent<AllyCommand>()) { gateDropdown.objectActionDropdown3.value = (int)ObjectE.AllyCommand; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[3].objectAction == selected.GetComponent<EnemyCommand>()) { gateDropdown.objectActionDropdown3.value = (int)ObjectE.EnemyCommand; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[3].objectAction == selected.GetComponent<LowestHealthEnemy>()) { gateDropdown.objectActionDropdown3.value = (int)ObjectE.LowestHealthEnemy; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[3].objectAction == selected.GetComponent<NearestAlly>()) { gateDropdown.objectActionDropdown3.value = (int)ObjectE.NearestAlly; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[3].objectAction == selected.GetComponent<NearestEnemy>()) { gateDropdown.objectActionDropdown3.value = (int)ObjectE.NearestEnemy; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[3].objectAction == selected.GetComponent<Self>()) { gateDropdown.objectActionDropdown3.value = (int)ObjectE.Self; }

                    if ((Object) selected.GetComponent<Status>().logicMatrix[4].objectAction == selected.GetComponent<AllyCommand>()) { gateDropdown.objectActionDropdown4.value = (int)ObjectE.AllyCommand; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[4].objectAction == selected.GetComponent<EnemyCommand>()) { gateDropdown.objectActionDropdown4.value = (int)ObjectE.EnemyCommand; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[4].objectAction == selected.GetComponent<LowestHealthEnemy>()) { gateDropdown.objectActionDropdown4.value = (int)ObjectE.LowestHealthEnemy; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[4].objectAction == selected.GetComponent<NearestAlly>()) { gateDropdown.objectActionDropdown4.value = (int)ObjectE.NearestAlly; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[4].objectAction == selected.GetComponent<NearestEnemy>()) { gateDropdown.objectActionDropdown4.value = (int)ObjectE.NearestEnemy; }
                    if ((Object) selected.GetComponent<Status>().logicMatrix[4].objectAction == selected.GetComponent<Self>()) { gateDropdown.objectActionDropdown4.value = (int)ObjectE.Self; }

                }
            }
        }
	}
}
