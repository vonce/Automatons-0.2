using UnityEngine;
using System.Collections;

public class InstantiateUnit : MonoBehaviour
{

    public GameObject UnitPrefab;
    GameObject Unit;
    public Transform Front;
    private float nextUnit;
    public float unitRate;
    private Status status;

    void Awake()
    {
        status = GetComponent<Status>();
        nextUnit = 0.0F;
    }

    void Update()
    {
        if (Time.time > nextUnit)
        {
            nextUnit = Time.time + unitRate;
            Unit = Instantiate(UnitPrefab, Front.position, Quaternion.identity) as GameObject;
            for (int i = 0; i <=5; i++)
            {
                Unit.GetComponent<Status>().logicMatrix[i] = GetComponent<Status>().logicMatrix[i];
            }
        }
    }
}

