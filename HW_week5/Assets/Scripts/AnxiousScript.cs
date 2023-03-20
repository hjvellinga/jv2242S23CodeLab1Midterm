using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using File = System.IO.File;
using Random = UnityEngine.Random;

public class AnxiousScript : MonoBehaviour
{
    private const string FILE_DIR = "/Data/";
    private const string FILE_NAME = "AnxiousText.txt";
    private string FILE_PATH;

    public TextMeshProUGUI textBubble; 
    // Start is called before the first frame update
    void Start()
    {
        FILE_PATH = Application.dataPath + FILE_DIR + FILE_NAME; 
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (File.Exists(FILE_PATH))
        {
            string fileContents = File.ReadAllText(FILE_PATH); //take contents from txt file 
            //turn into array
            string[] fileSplit = fileContents.Split('\n'); //split into lines
            Debug.Log(fileSplit.Length);
            
            //display text on screen
            textBubble.text = fileSplit[Random.Range(0, fileSplit.Length)];
        }
        Debug.Log("this one's anxiously attached and will close in on you and give damage when it touches you");
    }
}
