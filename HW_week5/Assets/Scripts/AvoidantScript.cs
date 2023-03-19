using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvoidantScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D col)
    {
        GameManager.instance.GetComponent<ASCIILevelLoaderScript>().HitNPC();
        Debug.Log(message: "This one's avoidant, when player enters trigger area it will run away and turn into a wall");
    }
}

//enemies have walking patterns and only spot the player in one direction (they are basically guards); 
//avoidant type: run away and turn into a wall 
//anxious type: run after player 
//upon touch: player's heart is broken. Restart. 
