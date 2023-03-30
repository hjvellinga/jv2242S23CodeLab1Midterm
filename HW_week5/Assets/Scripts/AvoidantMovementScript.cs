using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvoidantMovementScript : MonoBehaviour
{
    public float speed = 5f;
    public float forceAmount = 5;
    public Transform playerCharacterObject;
    public float minDistance = 1f;
    public float range; 
    // Start is called before the first frame update
    void Start()
    {
        range = Vector2.Distance(transform.position, playerCharacterObject.position);

    }

    // Update is called once per frame
     void Update()
    {
       /* if (range < minDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, playerCharacterObject.position,
                speed * Time.deltaTime);
        } */
    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.name.Contains("PlayerCharacter"))  //if Player Character enters trigger area, move away from Player Character, else remain still. 
        {
            transform.position =
                Vector2.MoveTowards(transform.position, playerCharacterObject.position, (forceAmount * speed) * Time.deltaTime);
        }
       /* else
        {
           transform.position = currentPos; 
        } */
    }
    
}
