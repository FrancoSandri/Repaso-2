using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehaviour : MonoBehaviour
{
    public float speed;
    public bool toRight;
    float yOffset = 1;
    public GameObject baseDer;
    public GameObject baseIzq;

    public GameObject prefab1;
    public GameObject prefab2;
    

    // Start is called before the first frame update
    void Start()
    {
        toRight = true;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (toRight)
        {
            transform.position += new Vector3(speed, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(speed, 0, 0);
        }

        if(transform.position.x > baseDer.transform.position.x - 1)
        {
            toRight = false;
            GameObject clon;
            clon = Instantiate(prefab1);
            clon.transform.position = baseDer.transform.position + new Vector3(0, yOffset, 0);
            yOffset++;
        }
        if(transform.position.x < baseIzq.transform.position.x + 1)
        {
            toRight = true;
            GameObject clon;
            clon = Instantiate(prefab2);
            clon.transform.position = baseIzq.transform.position + new Vector3(0, yOffset, 0);
            yOffset++;
        }
    }
}
