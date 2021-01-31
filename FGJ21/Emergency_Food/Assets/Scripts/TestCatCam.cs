using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCatCam : MonoBehaviour
{
    public Transform catPlayer;

    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        catPlayer = FindObjectOfType<PlayerController>().transform;
        offset = transform.position - catPlayer.position;
        
    }

    private void LateUpdate()
    {
        transform.position = catPlayer.position + offset;
    }
}
