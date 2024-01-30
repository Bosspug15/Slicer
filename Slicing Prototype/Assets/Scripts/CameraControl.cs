using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    private Transform trans;

    // Start is called before the first frame update
    void Start()
    {
        trans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a")) {
            transform.position += new Vector3(-5f, -0.8f, trans.position.z); 
        }

        if (Input.GetKeyDown("d"))
        {
            transform.position += new Vector3(-5f, -0.8f, trans.position.z);
        }
    }
}
