using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    public float maxHealth;
    public float maxSpecial;
    public float currentHealth;
    public float currentSpecial;
    public float percentHealth;
    public float percentSpecial;
    public GameObject healthBar;
    public GameObject specialBar;
    private float tempHealth;
    private float tempSpecial;
    private float calcHealth;
    private float calcSpecial;

    public void SetHealthBar(float myHealth)
    {
        healthBar.transform.localScale = new Vector3(myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }
    public void SetSpecialBar(float mySpecial)
    {
        specialBar.transform.localScale = new Vector3(mySpecial, specialBar.transform.localScale.y, specialBar.transform.localScale.z);
    }

    public void FullHealth()
    {
        currentHealth = maxHealth;
        float calcHealth = currentHealth / maxHealth;
        SetHealthBar(calcHealth);
        tempHealth = currentHealth;
        percentHealth = calcHealth * 100;
    }
    public void FullSpecial()
    {
        currentSpecial = maxSpecial;
        float calcSpecial = currentSpecial / maxSpecial;
        SetSpecialBar(calcSpecial);
        tempSpecial = currentSpecial;
        percentSpecial = calcSpecial * 100;
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
    public void SpecialCheck()
    {
        if (tempSpecial != currentSpecial)
        {
            calcSpecial = currentSpecial / maxSpecial;
            percentSpecial = calcSpecial * 100;
            SetSpecialBar(calcSpecial);
            tempSpecial = currentSpecial;
        }
    }
}
