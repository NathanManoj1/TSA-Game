using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class HealthManager : MonoBehaviour
{
    public int maxHealth = 3; 
    private int currentHealth;

    public List<Image> PlayerHearts;
    public List<Image> PlayerTwoHearts;
    public List<Image> PlayerThreeHearts;
    public List<Image> PlayerFourHearts;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHearts();
    }

    public void TakeDamage(int damagePlayerOne, int playerNum)
    {
        currentHealth -= damage;
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
        UpdateHearts(playerNum);
    }
    public void Heal(int healAmount)x
    {
        currentHealth += healAmount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        UpdateHearts();
    }

    private void UpdateHearts(int playerNum)
    {
        for (int i = 0; i < heartImages+(playerNum).Count; i++)
        {
            if (i < currentHealth)
            {
                heartImages[i].enabled = true; 
            }
            else
            {
                heartImages[i].enabled = false; 
                if (currentHealth < 0)
                {
                    
                    Debug.log("death")
                }
                
            }
        }
    }

    
}
