using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIselected : MonoBehaviour {

    public GameObject selected;
    public int[,] logicArray;
    public Dropdown ObjCondR1, CondR1, SubCondR1, ActR1, ObjActR1, ObjCondR2, CondR2, SubCondR2, ActR2, ObjActR2, ObjCondR3, CondR3, SubCondR3, ActR3, ObjActR3;

    void Start()
    {
        logicArray = new int[3, 5];
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 rayPos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
            RaycastHit2D hit = Physics2D.Raycast(rayPos, Vector2.zero, 0f);

            if (hit)
            {
                selected = hit.transform.gameObject;

                ObjCondR1.value = selected.GetComponent<LogicArray>().logic[0, 0];
                CondR1.value = selected.GetComponent<LogicArray>().logic[0, 1];
                SubCondR1.value = selected.GetComponent<LogicArray>().logic[0, 2] / 10;
                ActR1.value = selected.GetComponent<LogicArray>().logic[0, 4];
                ObjActR1.value = selected.GetComponent<LogicArray>().logic[0, 3];

                ObjCondR2.value = selected.GetComponent<LogicArray>().logic[1, 0];
                CondR2.value = selected.GetComponent<LogicArray>().logic[1, 1];
                SubCondR2.value = selected.GetComponent<LogicArray>().logic[1, 2] / 10;
                ActR2.value = selected.GetComponent<LogicArray>().logic[1, 4];
                ObjActR2.value = selected.GetComponent<LogicArray>().logic[1, 3];

                ObjCondR3.value = selected.GetComponent<LogicArray>().logic[2, 0];
                CondR3.value = selected.GetComponent<LogicArray>().logic[2, 1];
                SubCondR3.value = selected.GetComponent<LogicArray>().logic[2, 2] / 10;
                ActR3.value = selected.GetComponent<LogicArray>().logic[2, 4];
                ObjActR3.value = selected.GetComponent<LogicArray>().logic[2, 3];


                for (int i = 0; i < selected.GetComponent<LogicArray>().rows; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        logicArray[i, j] = selected.GetComponent<LogicArray>().logic[i, j];
                    }
                }
            }
            else
            {
                //selected = null;
            }
        }
        if (selected != null)
        {
            selected.GetComponent<LogicArray>().logic[0, 0] = ObjCondR1.value;
            selected.GetComponent<LogicArray>().logic[0, 1] = CondR1.value;
            selected.GetComponent<LogicArray>().logic[0, 2] = SubCondR1.value * 10;
            selected.GetComponent<LogicArray>().logic[0, 4] = ActR1.value;
            selected.GetComponent<LogicArray>().logic[0, 3] = ObjActR1.value;

            selected.GetComponent<LogicArray>().logic[1, 0] = ObjCondR2.value;
            selected.GetComponent<LogicArray>().logic[1, 1] = CondR2.value;
            selected.GetComponent<LogicArray>().logic[1, 2] = SubCondR2.value * 10;
            selected.GetComponent<LogicArray>().logic[1, 4] = ActR2.value;
            selected.GetComponent<LogicArray>().logic[1, 3] = ObjActR2.value;

            selected.GetComponent<LogicArray>().logic[2, 0] = ObjCondR3.value;
            selected.GetComponent<LogicArray>().logic[2, 1] = CondR3.value;
            selected.GetComponent<LogicArray>().logic[2, 2] = SubCondR3.value * 10;
            selected.GetComponent<LogicArray>().logic[2, 4] = ActR3.value;
            selected.GetComponent<LogicArray>().logic[2, 3] = ObjActR3.value;
        }
    }
}
