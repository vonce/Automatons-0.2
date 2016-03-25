using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    public float maxHealth;
    public float currentHealth;
    public float percentHealth;
    public GameObject healthBar;
    public GameObject bullet;
    private float calcHealth;


    void Start()
    {
        currentHealth = maxHealth;
        float calcHealth = currentHealth / maxHealth;
        SetHealthBar(calcHealth);
    }

    void OnTriggerEnter2D(Collider2D bullet)//trigger events
    {
        --currentHealth;
    }

    public void SetHealthBar(float myHealth)
    {
        healthBar.transform.localScale = new Vector3(myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }

    void Update()
    {
        calcHealth = currentHealth / maxHealth;
        percentHealth = calcHealth * 100;
        SetHealthBar(calcHealth);
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
