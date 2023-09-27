using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GoldBarPickup : MonoBehaviour
{
    public Player player;
    public Image goldBarImage;
    public GameObject goldBarCounter;
    
    void Start()
    {

    }

    public void goldBarPickup()
    {
        if (player.goldBarCounter == 0)
        {
            addGoldbarToInventory();
            goldBarImage.GetComponent<Image>().enabled = true;
            goldBarCounter.GetComponent<TextMeshProUGUI>().enabled = true;

        }
        else
        {
            addGoldbarToInventory();
        }
    }

    public void addGoldbarToInventory()
    {
        GetComponent<MeshRenderer>().enabled = false;
        player.goldBarCounter = player.goldBarCounter + 1;
        goldBarCounter.GetComponent<TextMeshProUGUI>().text = player.goldBarCounter.ToString();
        Debug.Log("test add goldbar to inventory");
    }
}
