using UnityEngine;
using System.Collections;

public class InstantiateUnit : MonoBehaviour
{

    public GameObject SoldierPrefab;
    public GameObject BruiserPrefab;
    public GameObject TankPrefab;
    public FactoryUnitTypeE UnitType;
    private GameObject InstantiatedUnit;
    private GameObject Unit;
    public Transform Front;
    private float nextUnit;
    public float unitRate;
    private Status status;

    void Awake()
    {
        if (UnitType == FactoryUnitTypeE.Soldier)
        {
            Unit = SoldierPrefab;
        }
        if (UnitType == FactoryUnitTypeE.Bruiser)
        {
            Unit = BruiserPrefab;
        }
        if (UnitType == FactoryUnitTypeE.Tank)
        {
            Unit = TankPrefab;
        }
        status = GetComponent<Status>();
    }

    void Update()
    {
        if (status.active == false)
        {
            if (UnitType == FactoryUnitTypeE.Soldier)
            {
                Unit = SoldierPrefab;
            }
            if (UnitType == FactoryUnitTypeE.Bruiser)
            {
                Unit = BruiserPrefab;
            }
            if (UnitType == FactoryUnitTypeE.Tank)
            {
                Unit = TankPrefab;
            }
        }
        if (Time.time > nextUnit && status.active == true)
        {
                nextUnit = Time.time + unitRate;
                InstantiatedUnit = Instantiate(Unit, Front.position, Quaternion.identity) as GameObject;
                InstantiatedUnit.tag = gameObject.tag;
                InstantiatedUnit.GetComponent<Status>().attackType = GetComponent<Status>().attackType;
                InstantiatedUnit.GetComponent<Status>().specialType = GetComponent<Status>().specialType;
                InstantiatedUnit.GetComponent<Status>().auraType = GetComponent<Status>().auraType;

                for (int i = 0; i <= 5; i++)
                {
                    InstantiatedUnit.GetComponent<Status>().logicMatrix[i] = GetComponent<Status>().logicMatrix[i];
                }
        }
    }
}

