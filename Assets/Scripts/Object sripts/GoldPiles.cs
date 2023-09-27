using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoldPiles : MonoBehaviour
{
    public GameObject subtitleText;

    void Start()
    {
        
    }

    public void interactWithGoldBarPile()
    {
        subtitleText.GetComponent<TextMeshProUGUI>().text = "I can't take this all. Maybe I should take the lose ones.";
        subtitleText.GetComponent<TextMeshProUGUI>().enabled = true;
        StartCoroutine(disableSubtitles());
    }

    IEnumerator disableSubtitles()
    {
        yield return new WaitForSeconds(6);
        subtitleText.GetComponent<TextMeshProUGUI>().enabled = false;
        subtitleText.GetComponent<TextMeshProUGUI>().text = "No subtitle...";
    }
}
