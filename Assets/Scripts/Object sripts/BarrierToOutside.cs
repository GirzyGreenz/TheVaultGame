using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BarrierToOutside : MonoBehaviour
{
    public Player player;
    public GameObject barriere;
    public GameObject subtitleText;

    public void OnTriggerEnter()
    {
        if (player.moneyCounter >= 2 && player.goldBarCounter >= 2)
        {
            barriere.GetComponent<BoxCollider>().enabled = false;
            subtitleText.GetComponent<TextMeshProUGUI>().text = "Ah yes, freedom!";
            subtitleText.GetComponent<TextMeshProUGUI>().enabled = true;
        } else
        {
            subtitleText.GetComponent<TextMeshProUGUI>().text = "I can't go yet with so little money and gold. Maybe I should grab some more...";
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
