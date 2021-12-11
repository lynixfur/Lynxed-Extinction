using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour
{

    public GameObject LynxIdle;

    public float speed = 2.0f;

    public bool lerp = true;

    void Update()
    {
        if (lerp)
        {
            float interpolation = speed * Time.deltaTime;

            Vector3 position = this.transform.position;
            position.y = Mathf.Lerp(this.transform.position.y, LynxIdle.transform.position.y, interpolation);
            position.x = Mathf.Lerp(this.transform.position.x, LynxIdle.transform.position.x, interpolation);

            this.transform.position = position;
        }

        else
        {
            float interpolation = speed * Time.deltaTime;

            Vector3 position = this.transform.position;
            position.y = (this.transform.position.y - LynxIdle.transform.position.y);
            position.x = (this.transform.position.x - LynxIdle.transform.position.x);

            transform.position -= position.normalized;
        }

    }
}