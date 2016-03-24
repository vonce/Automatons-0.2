using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    public float maxhealth;
    public float currenthealth;
    public GameObject healthBar;
    public GameObject bullet;


    void Start()
    {
        currenthealth = maxhealth;
        float calcHealth = currenthealth / maxhealth;
        SetHealthBar(calcHealth);
    }

    void OnTriggerEnter2D(Collider2D bullet)//trigger events
    {
        --currenthealth;
    }

    public void SetHealthBar(float myHealth)
    {
        healthBar.transform.localScale = new Vector3(myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }

    void Update()
    {

        float calcHealth = currenthealth / maxhealth;
        SetHealthBar(calcHealth);
        if (currenthealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
