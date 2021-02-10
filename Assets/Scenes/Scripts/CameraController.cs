using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    GameObject body;

    public float camHeight;

    // Start is called before the first frame update
    void Start()
    {
        body = GameObject.Find("Head");
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(body.transform.position.x,camHeight, -10);

          
    }
}
