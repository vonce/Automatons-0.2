using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    public float maxHealth;
    public float currentHealth;
    public float percentHealth;
    public GameObject healthBar;
    private float tempHealth;
    private float calcHealth;

    public void SetHealthBar(float myHealth)
    {
        healthBar.transform.localScale = new Vector3(myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }

    public void FullHealth()
    {
        currentHealth = maxHealth;
        float calcHealth = currentHealth / maxHealth;
        SetHealthBar(calcHealth);
        tempHealth = currentHealth;
        percentHealth = calcHealth * 100;
    }

    public void HealthCheck()
    {
        if (tempHealth != currentHealth)
        {
            calcHealth = currentHealth / maxHealth;
            percentHealth = calcHealth * 100;
            SetHealthBar(calcHealth);
            tempHealth = currentHealth;
            if (currentHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
