using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCatAfterImages : MonoBehaviour
{
    //the X and Y positions of the previous afterimage
    float lastImageXpos;
    float lastImageYpos;
    // distance required before next image can appear
    float distanceBetweenImages = 0.8f;
    // Start is called before the first frame update
    void Start()
    {
        lastImageXpos = transform.position.x;
        lastImageYpos = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        CastAfterImages();
    }

    void CastAfterImages()
    {
        if(Mathf.Abs(transform.position.x - lastImageXpos) > distanceBetweenImages || Mathf.Abs(transform.position.y - lastImageYpos) > distanceBetweenImages)
        {
            AfterimagePooler.Instance.GetFromPool();
            lastImageXpos = transform.position.x;
            lastImageYpos = transform.position.y;
        }
    }
}
