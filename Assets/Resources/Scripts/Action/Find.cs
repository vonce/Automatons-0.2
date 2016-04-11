using UnityEngine;
using System.Collections;

public class Find : MonoBehaviour
{
    /*
    private GameObject nearest;
    private Target target;
    private GameObject[] objectList;
    private GameObject[] objectList2;
    private Status status;
    private float distance;
    private UnitTypeE unitType;

    void Awake()
    {
        GameObject[] objectList = null;
        status = GetComponent<Status>();
    }

    void Update()
    {

    }

    public GameObject findObject(ConditionE condition, bool enemy, UnitTypeE unitType)
    {
        {
            if (enemy == true)//checks enemy
            {
                if (gameObject.tag == "Blue")
                {
                    objectList = GameObject.FindGameObjectsWithTag("Red");
                }
                if (gameObject.tag == "Red")
                {
                    objectList = GameObject.FindGameObjectsWithTag("Blue");
                }
            }
            else if (enemy == false)
            {
                if (gameObject.tag == "Blue")
                {
                    objectList = GameObject.FindGameObjectsWithTag("Blue");
                }
                if (gameObject.tag == "Red")
                {
                    objectList = GameObject.FindGameObjectsWithTag("Red");
                }
            }
            if (unitType == 0)
            {
                distance = Mathf.Infinity;
            }
            else
            {
                distance = status.sightRange;
            }
        }
        //if (condition == Condition.Nearest)
        {
            return Nearest();
        }
    }


    public GameObject Nearest()
    {
        if (unitType == UnitTypeE.Command)
        {
            distance = Mathf.Infinity;
        }
        else
        {
            distance = status.sightRange;
        }
        Vector2 position = transform.position;

        foreach (GameObject i in objectList)
        {
            Vector2 diff = i.transform.position - transform.position;
            float curDistance = diff.magnitude;
            if (curDistance < distance && i != gameObject)
            {
                if (unitType == UnitTypeE.Command)
                {
                    nearest = i;
                    distance = curDistance;
                }
                else if (unitType == i.GetComponent<Status>().unitType)
                {
                    nearest = i;
                    distance = curDistance;
                }
                else
                {
                    //nearest = null;
                }
            }
        }
        return nearest;
    }*/
}
