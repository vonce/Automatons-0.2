using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {
    /*
    public GameObject target;
    public Vector2 targetVector;
    public Vector2 unitVector;
    public float targetDistance;
    private ParseLogicArray parseLogicArray;

    void Awake()
    {
        parseLogicArray = GetComponent<ParseLogicArray>();
        if (gameObject.tag == "Red")
        {
            target = GameObject.Find("Blue_Command");
        }
        if (gameObject.tag == "Blue")
        {
            target = GameObject.Find("Red_Command");
        }
    }
    void Update()
    {
        target = parseLogicArray.objAct;

        if (target == null)
        {
            if (gameObject.tag == "Red")
            {
                target = GameObject.Find("Blue_Command");
            }
            if (gameObject.tag == "Blue")
            {
                target = GameObject.Find("Red_Command");
            }
        }
    }

    void FixedUpdate ()
    {
        if (target != null)
        {
            targetDistance = Vector2.Distance(new Vector2(target.transform.position.x, target.transform.position.y), new Vector2(transform.position.x, transform.position.y));                           
            //stores distance in "targetDistance"
        }
    }*/
}
