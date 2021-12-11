using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Moon will slowly go up?
        transform.position += new Vector3(0, Time.deltaTime);

        if(transform.localPosition.y >= 5f)
        {
        transform.localPosition = new Vector3(8.4f,-2.97f,10f);
        }
    }

    // Moon 50 times per second
    void FixedUpdate()
    {

    }
}
