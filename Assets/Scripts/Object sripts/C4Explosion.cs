using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class C4Explosion : MonoBehaviour
{
    public GameObject pointerArrow;
    public Player player;
    public GameObject breakableFloor;
    public Door doorToClose;
    public Image c4Sprite;

    public bool isPlaced;
    
    
    void Start()
    {
        isPlaced = false;
    }

    public void placeC4()
    {
        Debug.Log("PlaceC4 activated");

        if (player.hasC4 == true)
        {
            Debug.Log("Player has C4, meshrenderer placed C4 enabled");
            GetComponent<MeshRenderer>().enabled = true;
            GetComponent<BoxCollider>().enabled = false;
            pointerArrow.GetComponent<MeshRenderer>().enabled = false;
            isPlaced = true;
            c4Sprite.GetComponent<Image>().enabled = false;
        }
    }
}
