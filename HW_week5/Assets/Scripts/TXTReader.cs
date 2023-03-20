using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System; 

public class TXTReader : MonoBehaviour
{
    public TextAsset textAssetBarks; //allows to drag in the txt file component

    public string[] barks; //this string will go through each line in txt doc individually 

    //public TMP_Text[] textToBark;
    public TextMeshProUGUI[] textToBark;
    // Start is called before the first frame update
    void Start()
    {
        CallTextFromTXTFile();
        ApplyBarkstoTextBubble();
        ShuffleBarks();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CallTextFromTXTFile()
    {
        barks = textAssetBarks.text.Split(new string[] { "\n" }, StringSplitOptions.None);
    }
    void ApplyBarkstoTextBubble()
    {
        for (int i = 0; i < textToBark.Length; i++)
        {
            textToBark[i].text = barks[i];
        }
    }

    void ShuffleBarks()
    {
        for (int i = 0; i < 11; i++)
        {
            int index1 = UnityEngine.Random.Range(0, barks.Length);
            int index2 = index1;
            while (index2 == index1)
            {
                index2 = UnityEngine.Random.Range(0, barks.Length); 
            }

            string swapString = barks[index1];
            barks[index1] = barks[index2];
            barks[index2] = barks[index1];
        }
    }
}
