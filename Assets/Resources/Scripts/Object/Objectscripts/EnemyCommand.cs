using UnityEngine;
using System.Collections;

public class EnemyCommand : MonoBehaviour, IObject
{
    private GameObject[] enemyCommand;

    public ObjectE enumID()
    {
        return ObjectE.EnemyCommand;
    }

    public GameObject Object(Status status)
    {
        if (gameObject.tag == "Blue")
        {
            enemyCommand = GameObject.FindGameObjectsWithTag("Red");
        }
        if (gameObject.tag == "Red")
        {
            enemyCommand = GameObject.FindGameObjectsWithTag("Blue");
        }
        foreach(GameObject i in enemyCommand)
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
            enemyCommand = GameObject.FindGameObjectsWithTag("Red");
        }
        if (gameObject.tag == "Red")
        {
            enemyCommand = GameObject.FindGameObjectsWithTag("Blue");
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
