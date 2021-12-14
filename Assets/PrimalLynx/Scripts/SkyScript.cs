using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyScript : MonoBehaviour
{

    public Transform moon;
    public SpriteRenderer spr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // uh oh tts bot will read this code hehe ee
        float e = 0 - (moon.transform.position.y * 0.09f);
        Debug.Log(e);
        spr.color = new Color(e, e, e);
        //Debug.Log(moon.transform.position.y);
    }
}
