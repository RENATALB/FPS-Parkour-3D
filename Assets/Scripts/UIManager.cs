using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI DineroTXT;
    public TextMeshProUGUI HealthTXT;

    void Start()
    {
        DineroTXT.text = "$0";
    }

    public void UpdateMoneyText(string moneyAmount)
    {
        DineroTXT.text = "$" + moneyAmount;
    }
    public void UpdateHealthText(string moneyAmount)
    {
        HealthTXT.text = "HP " + moneyAmount;
    }
}
