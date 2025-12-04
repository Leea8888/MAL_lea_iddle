using UnityEngine;
using UnityEngine.UI;
using TMPro;
using JetBrains.Annotations;
using System.Collections;

public class GoldManager : MonoBehaviour
{
    public int tomatoAmount;
    public int sauceAmount;
    public int pastryAmount;
    public int rollingPinAmount;
    public TextMeshProUGUI tomatoText;
    public TextMeshProUGUI sauceText;
    public TextMeshProUGUI pastryText;
    public TextMeshProUGUI rollingPinText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void ChangeTomato()
    {
        tomatoAmount += 1;
        tomatoText.text = tomatoAmount.ToString("00");
    }

    public void ChangeSauce()
    {
        if (tomatoAmount > 2)
        {
            tomatoAmount -= 1;
            tomatoText.text = tomatoAmount.ToString("00");

            sauceAmount += 1;
            sauceText.text = sauceAmount.ToString("00");
        }
    }

    public void ChangePastry()
    { 
        if (sauceAmount > 2)
        {
            sauceAmount -= 1;
            sauceText.text = sauceAmount.ToString("00");

            pastryAmount += 1;
            pastryText.text = pastryAmount.ToString("00");
        }
    }

    public void ChangeRollingPin()
    {
        if (pastryAmount > 2)
        {
            pastryAmount -= 1;
            pastryText.text = pastryAmount.ToString("00");

            rollingPinAmount += 1;
            rollingPinText.text = rollingPinAmount.ToString("00");
            StartCoroutine(provokeAutoTomato());
        }
    }
     // Update is called once per frame
        void Update()
        {

        }
        
        public IEnumerator provokeAutoTomato()
        {
            while (true)
            {
            yield return new WaitForSeconds(2);
            ChangeTomato();
            }

        }
}
