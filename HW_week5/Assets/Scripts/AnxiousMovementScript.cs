using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnxiousMovementScript : MonoBehaviour
{
    public float speed = 5f;
    public float forceAmount = 5;
    public Transform playerCharacterObject;
    public float minDistance = 1f;
    public float range; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.name
            .Contains("PlayerCharacter")) //if Player Character enters trigger area, move away from Player Character, else remain still. 
        {
            transform.position =
                Vector2.MoveTowards(transform.position, playerCharacterObject.position,
                    -1 * (forceAmount * speed) * Time.deltaTime);
        }
    }
}
