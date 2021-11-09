using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{


    [SerializeField] private int maxHealth;
    [SerializeField] private int currentHealth;
    [SerializeField] private int damage;
    [SerializeField] private HealthBar healthBar;

    private void Start()
    {
        healthBar.setMaxHealth(maxHealth);
    }


    public void setDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.setHealth(currentHealth);
    }

    public int getDamage()
    {
        return damage;
    }

    public int getCurrentHealth()
    {
        return currentHealth;
    }
}
