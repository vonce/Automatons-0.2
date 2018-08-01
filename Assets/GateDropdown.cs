using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityScript.Lang;

public class GateDropdown : MonoBehaviour {

    private Select select;

    public float delayTime;

    public CanvasRenderer copyButton;
    public CanvasRenderer pasteButton;

    public Dropdown attackTypeDropdown;
    public Dropdown specialTypeDropdown;
    public Dropdown auraTypeDropdown;

    public Dropdown objectConditionDropdown0;
    public Dropdown conditionDropdown0;
    public Dropdown subOptionDropdown0;
    public Dropdown actionDropdown0;
    public Dropdown objectActionDropdown0;

    public Dropdown objectConditionDropdown1;
    public Dropdown conditionDropdown1;
    public Dropdown subOptionDropdown1;
    public Dropdown actionDropdown1;
    public Dropdown objectActionDropdown1;

    public Dropdown objectConditionDropdown2;
    public Dropdown conditionDropdown2;
    public Dropdown subOptionDropdown2;
    public Dropdown actionDropdown2;
    public Dropdown objectActionDropdown2;

    public Dropdown objectConditionDropdown3;
    public Dropdown conditionDropdown3;
    public Dropdown subOptionDropdown3;
    public Dropdown actionDropdown3;
    public Dropdown objectActionDropdown3;

    public Dropdown objectConditionDropdown4;
    public Dropdown conditionDropdown4;
    public Dropdown subOptionDropdown4;
    public Dropdown actionDropdown4;
    public Dropdown objectActionDropdown4;

    private ObjectE objectCondition0;
    private ConditionE condition0;
    private bool subOption0;
    private int subOptionPercent0;
    private ActionE action0;
    private ObjectE objectAction0;

    private ObjectE objectCondition1;
    private ConditionE condition1;
    private bool subOption1;
    private int subOptionPercent1;
    private ActionE action1;
    private ObjectE objectAction1;

    private ObjectE objectCondition2;
    private ConditionE condition2;
    private bool subOption2;
    private int subOptionPercent2;
    private ActionE action2;
    private ObjectE objectAction2;

    private ObjectE objectCondition3;
    private ConditionE condition3;
    private bool subOption3;
    private int subOptionPercent3;
    private ActionE action3;
    private ObjectE objectAction3;

    private ObjectE objectCondition4;
    private ConditionE condition4;
    private bool subOption4;
    private int subOptionPercent4;
    private ActionE action4;
    private ObjectE objectAction4;

    private ObjectE objectCondition5;
    private ConditionE condition5;
    private bool subOption5;
    private int subOptionPercent5;
    private ActionE action5;
    private ObjectE objectAction5;

    private LogicGate logicGate0 = new LogicGate();
    private LogicGate logicGate1 = new LogicGate();
    private LogicGate logicGate2 = new LogicGate();
    private LogicGate logicGate3 = new LogicGate();
    private LogicGate logicGate4 = new LogicGate();
    private LogicGate logicGate5 = new LogicGate();

    private AttackTypeE copyAttackType;
    private SpecialTypeE copySpecialType;
    private AuraTypeE copyAuraType;

    private LogicGate copyLogicGate0 = new LogicGate();
    private LogicGate copyLogicGate1 = new LogicGate();
    private LogicGate copyLogicGate2 = new LogicGate();
    private LogicGate copyLogicGate3 = new LogicGate();
    private LogicGate copyLogicGate4 = new LogicGate();
    private LogicGate copyLogicGate5 = new LogicGate();


    //populate dropdown menus with enum values
    void AttackDropdown(Dropdown dropdown)
    {
        List<string> attacklistnames = new List<string>();
        string[] attacknames = ObjectE.GetNames(typeof(AttackTypeE));
        foreach (string i in attacknames)
        {
            attacklistnames.Add(i);
        }
        dropdown.ClearOptions();
        dropdown.AddOptions(attacklistnames);
    }

    void SpecialDropdown(Dropdown dropdown)
    {
        List<string> speciallistnames = new List<string>();
        string[] specialnames = ObjectE.GetNames(typeof(SpecialTypeE));
        foreach (string i in specialnames)
        {
            speciallistnames.Add(i);
        }
        dropdown.ClearOptions();
        dropdown.AddOptions(speciallistnames);
    }

    void AuraDropdown(Dropdown dropdown)
    {
        List<string> auralistnames = new List<string>();
        string[] auranames = ObjectE.GetNames(typeof(AuraTypeE));
        foreach (string i in auranames)
        {
            auralistnames.Add(i);
        }
        dropdown.ClearOptions();
        dropdown.AddOptions(auralistnames);
    }

    void ObjectDropdown (Dropdown dropdown)
    {
        List<string> objlistnames = new List<string>();
        string[] objnames = ObjectE.GetNames(typeof(ObjectE));
        foreach (string i in objnames)
        {
            objlistnames.Add(i);
        }
        dropdown.ClearOptions();
        dropdown.AddOptions(objlistnames);
    }

    void ConditionDropdown(Dropdown dropdown)
    {
        List<string> condlistnames = new List<string>();
        string[] condnames = ConditionE.GetNames(typeof(ConditionE));
        foreach (string i in condnames)
        {
            condlistnames.Add(i);
        }
        dropdown.ClearOptions();
        dropdown.AddOptions(condlistnames);
    }

    void ActionDropdown(Dropdown dropdown)
    {
        List<string> actlistnames = new List<string>();
        string[] actnames = ActionE.GetNames(typeof(ActionE));
        foreach (string i in actnames)
        {
            actlistnames.Add(i);
        }
        dropdown.ClearOptions();
        dropdown.AddOptions(actlistnames);
    }
    void Start ()
    {
        select = gameObject.GetComponent<Select>();

        copyButton.GetComponent<Button>().onClick.AddListener(copy);
        pasteButton.GetComponent<Button>().onClick.AddListener(paste);

        attackTypeDropdown.onValueChanged.AddListener(delegate { DropdownValueChanged(); });
        specialTypeDropdown.onValueChanged.AddListener(delegate { DropdownValueChanged(); });
        auraTypeDropdown.onValueChanged.AddListener(delegate { DropdownValueChanged(); });

        objectConditionDropdown0.onValueChanged.AddListener(delegate { DropdownValueChanged(); });
        objectConditionDropdown1.onValueChanged.AddListener(delegate { DropdownValueChanged(); });
        objectConditionDropdown2.onValueChanged.AddListener(delegate { DropdownValueChanged(); });
        objectConditionDropdown3.onValueChanged.AddListener(delegate { DropdownValueChanged(); });
        objectConditionDropdown4.onValueChanged.AddListener(delegate { DropdownValueChanged(); });

        conditionDropdown0.onValueChanged.AddListener(delegate { DropdownValueChanged(); });
        conditionDropdown1.onValueChanged.AddListener(delegate { DropdownValueChanged(); });
        conditionDropdown2.onValueChanged.AddListener(delegate { DropdownValueChanged(); });
        conditionDropdown3.onValueChanged.AddListener(delegate { DropdownValueChanged(); });
        conditionDropdown4.onValueChanged.AddListener(delegate { DropdownValueChanged(); });

        actionDropdown0.onValueChanged.AddListener(delegate { DropdownValueChanged(); });
        actionDropdown1.onValueChanged.AddListener(delegate { DropdownValueChanged(); });
        actionDropdown2.onValueChanged.AddListener(delegate { DropdownValueChanged(); });
        actionDropdown3.onValueChanged.AddListener(delegate { DropdownValueChanged(); });
        actionDropdown4.onValueChanged.AddListener(delegate { DropdownValueChanged(); });

        objectActionDropdown0.onValueChanged.AddListener(delegate { DropdownValueChanged(); });
        objectActionDropdown1.onValueChanged.AddListener(delegate { DropdownValueChanged(); });
        objectActionDropdown2.onValueChanged.AddListener(delegate { DropdownValueChanged(); });
        objectActionDropdown3.onValueChanged.AddListener(delegate { DropdownValueChanged(); });
        objectActionDropdown4.onValueChanged.AddListener(delegate { DropdownValueChanged(); });

        AttackDropdown(attackTypeDropdown);
        SpecialDropdown(specialTypeDropdown);
        AuraDropdown(auraTypeDropdown);

        ObjectDropdown(objectConditionDropdown0);
        ObjectDropdown(objectConditionDropdown1);
        ObjectDropdown(objectConditionDropdown2);
        ObjectDropdown(objectConditionDropdown3);
        ObjectDropdown(objectConditionDropdown4);

        ConditionDropdown(conditionDropdown0);
        ConditionDropdown(conditionDropdown1);
        ConditionDropdown(conditionDropdown2);
        ConditionDropdown(conditionDropdown3);
        ConditionDropdown(conditionDropdown4);

        ActionDropdown(actionDropdown0);
        ActionDropdown(actionDropdown1);
        ActionDropdown(actionDropdown2);
        ActionDropdown(actionDropdown3);
        ActionDropdown(actionDropdown4);

        ObjectDropdown(objectActionDropdown0);
        ObjectDropdown(objectActionDropdown1);
        ObjectDropdown(objectActionDropdown2);
        ObjectDropdown(objectActionDropdown3);
        ObjectDropdown(objectActionDropdown4);

    }
	
	//Update is called once per frame
	void Update ()
    {
        
    }

    void copy ()
    {
        if (select != null)
        {
            copyAttackType = (AttackTypeE)attackTypeDropdown.value;
            copySpecialType = (SpecialTypeE)specialTypeDropdown.value;
            copyAuraType = (AuraTypeE)auraTypeDropdown.value;

            copyLogicGate0 = select.selected.GetComponent<Status>().logicMatrix[0];
            copyLogicGate1 = select.selected.GetComponent<Status>().logicMatrix[1];
            copyLogicGate2 = select.selected.GetComponent<Status>().logicMatrix[2];
            copyLogicGate3 = select.selected.GetComponent<Status>().logicMatrix[3];
            copyLogicGate4 = select.selected.GetComponent<Status>().logicMatrix[4];
        }
    }

    void paste ()
    {
        if (select != null)
        {
            select.selected.GetComponent<Status>().attackType = copyAttackType;
            select.selected.GetComponent<Status>().specialType = copySpecialType;
            select.selected.GetComponent<Status>().auraType = copyAuraType;

            select.selected.GetComponent<Status>().logicMatrix[0] = copyLogicGate0;
            select.selected.GetComponent<Status>().logicMatrix[1] = copyLogicGate1;
            select.selected.GetComponent<Status>().logicMatrix[2] = copyLogicGate2;
            select.selected.GetComponent<Status>().logicMatrix[3] = copyLogicGate3;
            select.selected.GetComponent<Status>().logicMatrix[4] = copyLogicGate4;

/*            attackTypeDropdown.value = (int)select.selected.GetComponent<Status>().attackType;
            specialTypeDropdown.value = (int)select.selected.GetComponent<Status>().specialType;
            auraTypeDropdown.value = (int)select.selected.GetComponent<Status>().auraType;

            objectConditionDropdown0.value = (int)select.selected.GetComponent<Status>().logicMatrix[0].objectCondition.enumID();
            objectConditionDropdown1.value = (int)select.selected.GetComponent<Status>().logicMatrix[1].objectCondition.enumID();
            objectConditionDropdown2.value = (int)select.selected.GetComponent<Status>().logicMatrix[2].objectCondition.enumID();
            objectConditionDropdown3.value = (int)select.selected.GetComponent<Status>().logicMatrix[3].objectCondition.enumID();
            objectConditionDropdown4.value = (int)select.selected.GetComponent<Status>().logicMatrix[4].objectCondition.enumID();

            conditionDropdown0.value = (int)select.selected.GetComponent<Status>().logicMatrix[0].condition.enumID();
            conditionDropdown1.value = (int)select.selected.GetComponent<Status>().logicMatrix[1].condition.enumID();
            conditionDropdown2.value = (int)select.selected.GetComponent<Status>().logicMatrix[2].condition.enumID();
            conditionDropdown3.value = (int)select.selected.GetComponent<Status>().logicMatrix[3].condition.enumID();
            conditionDropdown4.value = (int)select.selected.GetComponent<Status>().logicMatrix[4].condition.enumID();

            actionDropdown0.value = (int)select.selected.GetComponent<Status>().logicMatrix[0].action.enumID();
            actionDropdown1.value = (int)select.selected.GetComponent<Status>().logicMatrix[1].action.enumID();
            actionDropdown2.value = (int)select.selected.GetComponent<Status>().logicMatrix[2].action.enumID();
            actionDropdown3.value = (int)select.selected.GetComponent<Status>().logicMatrix[3].action.enumID();
            actionDropdown4.value = (int)select.selected.GetComponent<Status>().logicMatrix[4].action.enumID();

            objectActionDropdown0.value = (int)select.selected.GetComponent<Status>().logicMatrix[0].objectAction.enumID();
            objectActionDropdown1.value = (int)select.selected.GetComponent<Status>().logicMatrix[1].objectAction.enumID();
            objectActionDropdown2.value = (int)select.selected.GetComponent<Status>().logicMatrix[2].objectAction.enumID();
            objectActionDropdown3.value = (int)select.selected.GetComponent<Status>().logicMatrix[3].objectAction.enumID();
            objectActionDropdown4.value = (int)select.selected.GetComponent<Status>().logicMatrix[4].objectAction.enumID();*/
        }
    }

    void DropdownValueChanged ()
    {
        objectCondition0 = (ObjectE)objectConditionDropdown0.value;
        objectCondition1 = (ObjectE)objectConditionDropdown1.value;
        objectCondition2 = (ObjectE)objectConditionDropdown2.value;
        objectCondition3 = (ObjectE)objectConditionDropdown3.value;
        objectCondition4 = (ObjectE)objectConditionDropdown4.value;

        condition0 = (ConditionE)conditionDropdown0.value;
        condition1 = (ConditionE)conditionDropdown1.value;
        condition2 = (ConditionE)conditionDropdown2.value;
        condition3 = (ConditionE)conditionDropdown3.value;
        condition4 = (ConditionE)conditionDropdown4.value;

        action0 = (ActionE)actionDropdown0.value;
        action1 = (ActionE)actionDropdown1.value;
        action2 = (ActionE)actionDropdown2.value;
        action3 = (ActionE)actionDropdown3.value;
        action4 = (ActionE)actionDropdown4.value;

        objectAction0 = (ObjectE)objectActionDropdown0.value;
        objectAction1 = (ObjectE)objectActionDropdown1.value;
        objectAction2 = (ObjectE)objectActionDropdown2.value;
        objectAction3 = (ObjectE)objectActionDropdown3.value;
        objectAction4 = (ObjectE)objectActionDropdown4.value;
        
        if (select != null && delayTime <= Time.time)
        {
            select.selected.GetComponent<Status>().attackType = (AttackTypeE)attackTypeDropdown.value;
            select.selected.GetComponent<Status>().specialType = (SpecialTypeE)specialTypeDropdown.value;
            select.selected.GetComponent<Status>().auraType = (AuraTypeE)auraTypeDropdown.value;

            logicGate0 = select.selected.GetComponent<GateSelector>().Gate(objectCondition0, condition0, subOption0, subOptionPercent0, action0, objectAction0);
            logicGate1 = select.selected.GetComponent<GateSelector>().Gate(objectCondition1, condition1, subOption1, subOptionPercent1, action1, objectAction1);
            logicGate2 = select.selected.GetComponent<GateSelector>().Gate(objectCondition2, condition2, subOption2, subOptionPercent2, action2, objectAction2);
            logicGate3 = select.selected.GetComponent<GateSelector>().Gate(objectCondition3, condition3, subOption3, subOptionPercent3, action3, objectAction3);
            logicGate4 = select.selected.GetComponent<GateSelector>().Gate(objectCondition4, condition4, subOption4, subOptionPercent4, action4, objectAction4);

            select.selected.GetComponent<Status>().logicMatrix[0] = logicGate0;
            select.selected.GetComponent<Status>().logicMatrix[1] = logicGate1;
            select.selected.GetComponent<Status>().logicMatrix[2] = logicGate2;
            select.selected.GetComponent<Status>().logicMatrix[3] = logicGate3;
            select.selected.GetComponent<Status>().logicMatrix[4] = logicGate4;
            
        }
    }
}
