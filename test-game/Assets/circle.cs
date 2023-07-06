using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circle : MonoBehaviour
{
    public float lerpFactor = 0;
    public float travelDist;
    public float speed;
    Vector3 point1;
    Vector3 point2;
    bool up;

    // Start is called before the first frame update
    void Start()
    {
        point1 = new Vector3(transform.position.x, transform.position.y + travelDist, transform.position.z);
        point2 = new Vector3(transform.position.x, transform.position.y - travelDist, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, Mathf.Sin(Time.time) * speed, transform.position.z);
        /*        transform.position = Vector3.Lerp(point1, point2, lerpFactor);

                if (up)
                {
                    lerpFactor += Time.deltaTime * speed;
                }
                else
                {
                    lerpFactor -= Time.deltaTime * speed;
                }

                if (lerpFactor >= 1)
                {
                    up = false;
                }
                if (lerpFactor <= 0)
                {
                    up = true;
                }
            }*/
    }
}
