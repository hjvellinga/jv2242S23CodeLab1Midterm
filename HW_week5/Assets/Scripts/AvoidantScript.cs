using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;
using System.IO; 
using TMPro;
using File = System.IO.File;

public class AvoidantScript : MonoBehaviour
{
    private const string FILE_DIR = "/Data/";
    private const string FILE_NAME = "AvoidantText.txt";
    private string FILE_PATH;

    public TextMeshProUGUI textBubble;
    public TextMeshProUGUI startOverText;

    public List<string> avoidantText = new List<string>(); //make a list of AvoidantText
    //public TextMeshPro textBubble; 

    // Start is called before the first frame update
    void Start()
    {
        FILE_PATH = Application.dataPath + FILE_DIR + FILE_NAME;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name.Contains("PlayerCharacter"))
        {
        Debug.Log(
            message: "This one's avoidant, when player enters trigger area it will run away and turn into a wall");
        textBubble.text = "Hello"; 
        
        if (File.Exists(FILE_PATH))
        {
            string fileContents = File.ReadAllText(FILE_PATH); //distill contents of txt file into strings

            //turn strings into array
            string[] fileSplit = fileContents.Split('\n'); //split into lines
            Debug.Log(fileSplit.Length);
            // for (int i = 1; i < fileSplit.Length - 1; i++)
           // {
           //     avoidantText.Add(fileSplit[i]);
           // }

            //display the text on the screen
            textBubble.text = fileSplit[Random.Range(0,fileSplit.Length)];
        }
        //textBubble.GetComponent<TXTReader>().CallTextFromTXTFile(); //call all the functions in the TXT Script because apparently you can't call a whole script
        //textBubble.GetComponent<TXTReader>().ApplyBarkstoTextBubble(); 
        //textBubble.GetComponent<TXTReader>().ShuffleBarks();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("PlayerCharacter"))
        {
            startOverText.text = "Try again"; //TODO drag object into field!!
            GameManager.instance.GetComponent<ASCIILevelLoaderScript>().LoadLevel();
        }
    }
}

//enemies have walking patterns and only spot the player in one direction (they are basically guards); 
//avoidant type: run away and turn into a wall 
//anxious type: run after player 
//upon touch: player's heart is broken. Restart. 
