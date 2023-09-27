using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PalletTransporter : MonoBehaviour
{

    Animator palletLoaderAnimator;
    Animator storageShelfAnimator;

    public GameObject palletLoader;
    public GameObject storageShelf;
    public GameObject breakableWall;
    public Player player;
    public KeycardSlot keycardSlot;
    public GameObject subtitleText;



    void Start()
    {
        palletLoaderAnimator = palletLoader.GetComponent<Animator>();
        storageShelfAnimator = storageShelf.GetComponent<Animator>();
    }

    public void drivePalletTransporter()
    {
        //must change in future to if keycard is inserted
        if (keycardSlot.isKeyCardInserted == false)
        {
            palletLoaderAnimator.SetTrigger("Push button");
        } else
        {
            StartCoroutine(fallOverShelfTrigger());
            palletLoaderAnimator.SetTrigger("Keycard inserted");
        }
    }

    IEnumerator fallOverShelfTrigger()
    {
        Debug.Log("test fallOverShelfTrigger()");
        yield return new WaitForSeconds(4);
        storageShelfAnimator.SetTrigger("Fall over");
        StartCoroutine(breakWall());
    }

    IEnumerator breakWall()
    {
        yield return new WaitForSeconds(2);
        breakableWall.GetComponent<MeshRenderer>().enabled = false;
        breakableWall.GetComponent<BoxCollider>().enabled = false;
        useSubtitles("Jezus, the storrage shelf broke the wall.");
    }

    public void useSubtitles(string subtitleTextInput)
    {
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


