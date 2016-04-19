using UnityEngine;
using System.Collections;

public class AllyCommand : MonoBehaviour, IObject
{
    private GameObject[] enemyCommand;

    public GameObject Object(Status status)
    {
        if (gameObject.tag == "Blue")
        {
            enemyCommand = GameObject.FindGameObjectsWithTag("Blue");
        }
        if (gameObject.tag == "Red")
        {
            enemyCommand = GameObject.FindGameObjectsWithTag("Red");
        }
        foreach (GameObject i in enemyCommand)
        {
            if (i.GetComponent<Status>().unitType == UnitTypeE.Command)
            {
                return i;
            }
        }
        return null;
    }
    public GameObject Object(Status status, SubOption subOption)
    {
        if (gameObject.tag == "Blue")
        {
            enemyCommand = GameObject.FindGameObjectsWithTag("Blue");
        }
        if (gameObject.tag == "Red")
        {
            enemyCommand = GameObject.FindGameObjectsWithTag("Red");
        }
        foreach (GameObject i in enemyCommand)
        {
            if (i.GetComponent<Status>().unitType == UnitTypeE.Command)
            {
                return i;
            }
        }
        return null;
    }
}
