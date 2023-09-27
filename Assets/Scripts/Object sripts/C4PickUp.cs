using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class C4PickUp : MonoBehaviour
{

    public Player player;
    public GameObject placedC4;
    public GameObject pointerArrow;
    public Image c4Sprite;



    void Start()
    {
        
    }

    public void pickUpC4()
    {
        Debug.Log("Picks up C4 enabled");
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
        placedC4.GetComponent<BoxCollider>().enabled = true;
        pointerArrow.GetComponent<MeshRenderer>().enabled = true;
        player.hasC4 = true;
        c4Sprite.GetComponent<Image>().enabled = true; 
    }

}
