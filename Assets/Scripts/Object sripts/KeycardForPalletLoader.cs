using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeycardForPalletLoader : MonoBehaviour
{
    public Player player;
    public Image keycardImage;
    

    void Start()
    {
        
    }

    public void pickUpKeyCard()
    {
        player.hasKeyCard = true;
        keycardImage.GetComponent<Image>().enabled = true;
        GetComponent<MeshRenderer>().enabled = false;
    }
}
