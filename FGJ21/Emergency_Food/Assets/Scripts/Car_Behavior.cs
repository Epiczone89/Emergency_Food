using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Behavior : MonoBehaviour
{
    public float delay = 0;
    public float speed = 20f;
    Vector3 targetPoint;
    Vector3 startPoint;

    // Object colour array
    public Sprite[] sprites;

    // Reference to child sprite
    public SpriteRenderer vehicle;

    // Start is called before the first frame update
    void Start()
    {
        // Gets SpriteRenderer from child 
        vehicle = GetComponentInChildren<SpriteRenderer>();
        // Randomize cars sprites
        vehicle.sprite = sprites[Random.Range(0, sprites.Length)];


        // Cars start point
        startPoint = transform.position;
        // Point where car stops
        targetPoint = new Vector3(startPoint.x, startPoint.y - 31f, startPoint.z - 145f);
        // Makes cars speed random
        speed += Random.Range(-5, 5);
    }

    // Update is called once per frame
    void Update()
    {
        // Delays car movement on startPoint;
        if(delay > 0)
        {
            delay -= Time.deltaTime;
        }
        else
        {
            // Car movement
            transform.position = Vector3.MoveTowards(transform.position, targetPoint, Time.deltaTime * speed);

            // When car gets to targetPoint it loops back to startPoint
            if(transform.position.z < targetPoint.z+1)
            {
                transform.position = startPoint;
            }
        }
    }
}