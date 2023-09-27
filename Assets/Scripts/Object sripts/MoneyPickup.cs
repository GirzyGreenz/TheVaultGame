using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MoneyPickup : MonoBehaviour
{
    public Player player;
    public Image moneyStackImage;
    public GameObject moneyStackCounter;

    void Start()
    {
        
    }


    public void moneyPickup()
    {
        if (player.moneyCounter == 0)
        {
            addMoneyStackToInventory();
            moneyStackImage.GetComponent<Image>().enabled = true;
            moneyStackCounter.GetComponent<TextMeshProUGUI>().enabled = true;

        }
        else
        {
            addMoneyStackToInventory();
        }
    }

    public void addMoneyStackToInventory()
    {
        GetComponent<MeshRenderer>().enabled = false;
        player.moneyCounter = player.moneyCounter + 1;
        moneyStackCounter.GetComponent<TextMeshProUGUI>().text = player.moneyCounter.ToString();
        Debug.Log("test add money stack to inventory");
    }    
}
