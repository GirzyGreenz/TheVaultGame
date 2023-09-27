using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class KeycardSlot : MonoBehaviour
{
    Animator insertKeyCardAnimator;

    public GameObject palletLoader;
    public GameObject keycard;
    public bool isKeyCardInserted;
    public Player player;
    public Image keycardImage;
    public GameObject subtitleText;

    void Start()
    {
        isKeyCardInserted = false;
        insertKeyCardAnimator = palletLoader.GetComponent<Animator>();
    }

    public void insertKeycard()
    {
        if  (player.hasKeyCard == true)
        {
            keycard.GetComponent<MeshRenderer>().enabled = true;
            insertKeyCardAnimator.SetTrigger("Has keycard");
            player.hasKeyCard = false;
            isKeyCardInserted = true;
            keycardImage.GetComponent<Image>().enabled = false;
            useSubtitles("Yes, it workt! I can now use the transporter.");
        } 
        else
        {
            useSubtitles("Maybe I can find something to activate this pallet transporter.");
        }
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
