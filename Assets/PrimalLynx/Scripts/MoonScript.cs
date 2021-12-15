using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonScript : MonoBehaviour
{

    private float timeline = 60 * 20;
    private float timer = 0f;
    //public Transform lynxpos;
    public float MoonTimeline = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        // Moon will slowly go up?
        //transform.position += new Vector3(0, Time.deltaTime * 0.10f);

        //if(transform.localPosition.y >= 5f)
        //{
        //transform.localPosition = new Vector3(8.4f,-2.97f,10f);
        //}
       // Debug.Log(lynxpos.position);
       // transform.position = new Vector3(lynxpos.position.x + (8*Mathf.Cos(timer/MoonTimeline)),5*Mathf.Sin(timer/MoonTimeline) -6.682f,0f);
    }

    // Moon 50 times per second
    void FixedUpdate()
    {

    }
}
