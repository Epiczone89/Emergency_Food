using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatFollow : MonoBehaviour
{
    // catPlayers transform
    Transform catPlayer;

    // Start is called before the first frame update
    void Start()
    {
        // Finds PlayerController
        catPlayer = FindObjectOfType<PlayerController>().transform;
    }

    private void LateUpdate()
    {
        // Finds catPlayers position.x
        transform.position = new Vector3(catPlayer.position.x +10, catPlayer.position.y +3, transform.position.z);
    }
}