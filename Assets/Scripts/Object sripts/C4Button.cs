using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class C4Button : MonoBehaviour
{
    Animator c4ButtonAnimator;

    public GameObject breakableFloor;
    public GameObject placedC4Mesh;
    public C4Explosion placedC4;
    public GameObject subtitleText;
    public Door door;
    public bool explosiveDidBoom;

    void Start()
    {
        explosiveDidBoom = false;
        c4ButtonAnimator = GetComponent<Animator>();
    }

    public void triggerExplosion()
    {
        if (explosiveDidBoom == false)
        {
            if (door.isDoorAllreadyOpen == false && placedC4.isPlaced == true)
            {
                //explosionTriggeredWithButton();
                explosiveDidBoom = true;
                c4ButtonAnimator.SetTrigger("Push button");
                breakableFloor.GetComponent<MeshRenderer>().enabled = false;
                breakableFloor.GetComponent<BoxCollider>().enabled = false;
                placedC4Mesh.GetComponent<MeshRenderer>().enabled = false;
            }
            else if (door.isDoorAllreadyOpen == true && placedC4.isPlaced == true)
            {
                useSubtitles("I should close the door first, before setting the explosive off.");
            }
            else
            {
                useSubtitles("I should first place the bomb.");
            }
        }
        else
        {
            c4ButtonAnimator.SetTrigger("Push button");
            useSubtitles("I already used that.");
        }

    }

    /*IEnumerator explosionTriggeredWithButton()
    {
        yield return new WaitForSeconds(2);
        c4ButtonAnimator.SetTrigger("Push button");
        breakableFloor.GetComponent<MeshRenderer>().enabled = false;
        breakableFloor.GetComponent<BoxCollider>().enabled = false;
        placedC4Mesh.GetComponent<MeshRenderer>().enabled = false;
    }*/

    public void useSubtitles(string subtitleTextInput) {
        subtitleText.GetComponent<TextMeshProUGUI>().text = subtitleTextInput;
        subtitleText.GetComponent<TextMeshProUGUI>().enabled = true;
        StartCoroutine(disableSubtitles());
    }

    IEnumerator disableSubtitles()
    {
        yield return new WaitForSeconds(4);
        subtitleText.GetComponent<TextMeshProUGUI>().enabled = false;
        subtitleText.GetComponent<TextMeshProUGUI>().text = "No subtitle...";
    }
}
