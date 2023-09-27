using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject subtitleText;
    public bool alreadyTriggered = false;

    public void OnTriggerEnter()
    {
        if (alreadyTriggered == false)
        {
            subtitleText.GetComponent<TextMeshProUGUI>().text = "Now I locked myself in and I got C4. Time to pull of a bankheist!";
            subtitleText.GetComponent<TextMeshProUGUI>().enabled = true;
            StartCoroutine(disableSubtitles());
        }
    }

    IEnumerator disableSubtitles()
    {
        yield return new WaitForSeconds(4);
        subtitleText.GetComponent<TextMeshProUGUI>().enabled = false;
        subtitleText.GetComponent<TextMeshProUGUI>().text = "No subtitle...";
    }
}
