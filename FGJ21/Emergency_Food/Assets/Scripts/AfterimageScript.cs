using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterimageScript : MonoBehaviour
{
    private Transform catPlayer;

    //Player cat's Sprite Renderer
    private SpriteRenderer catRend;
    //Afterimage's sprite renderer
    private SpriteRenderer catGhost;

    private Color catColor;
    //Time the afterimage is active
    private float activeTime = 0.9f;
    //When the afterimage was activated
    private float timeActivated;
    private float alpha;
    [SerializeField]
    private float alphaSet = 0.8f;
    private float alphaMultiplier = 0.95f;

    private void OnEnable()
    {
        catGhost = GetComponent<SpriteRenderer>();
        catPlayer = GameObject.FindGameObjectWithTag("Player").transform;
        catRend = catPlayer.GetComponent<SpriteRenderer>();

        alpha = alphaSet;
        catGhost.sprite = catRend.sprite;
        catGhost.flipX = catRend.flipX;
        transform.position = catPlayer.position;
        timeActivated = Time.time;
    }

    private void Update()
    {
        alpha *= alphaMultiplier;
        catColor = new Color(0.9f, 0.0f, 1f, alpha);
        catGhost.color = catColor;

        if(Time.time >= (timeActivated + activeTime))
        {
            //Add back to pool
            AfterimagePooler.Instance.AddToPool(gameObject);
        }
    }

}
