using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public float money;
    public TextMeshProUGUI cartelDinero;

    private void Start()
    {
        cartelDinero.text = "Dinero actual: $" + money;
    }
    
    public bool UpdateMoney (float amount)
    {
        if (money + amount < 0)
        {
            cartelDinero.text = "No te alcanza";
            return false;
        }
        else
        {
            money += amount;
            cartelDinero.text = "Dinero actual: $" + money;
            return true;
        }
    }
    // Esto no se si esta bien o mal
    public void Update()
    {
        cartelDinero.text = "Dinero actual: $" + money;
    }
}
