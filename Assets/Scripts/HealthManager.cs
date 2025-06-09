using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthManager : MonoBehaviour
{
    public int healthPoints;
    public UIManager uimanager;

    private void Start()
    {
        uimanager = FindObjectOfType<UIManager>();
        uimanager.UpdateHealthText(healthPoints.ToString());
    }

    public void UpdateHealth(int damageAmount)
    {
        if (healthPoints + damageAmount <= 0)
        {
            Debug.Log("Game over");
            healthPoints = 0;
            uimanager.UpdateHealthText(healthPoints.ToString());
            return;
        }

        healthPoints += damageAmount;
        uimanager.UpdateHealthText(healthPoints.ToString());
    }

    void GameOverActions()
    {

    }
}
