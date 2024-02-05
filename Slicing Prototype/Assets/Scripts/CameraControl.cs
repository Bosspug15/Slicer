using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraControl : MonoBehaviour
{

    private Transform trans;
    [SerializeField] private Transform cubeTrans;

    // Start is called before the first frame update
    void Start()
    {
        trans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKeyDown("a")) { 
            transform.RotateAround(cubeTrans.position, Vector3.up, 5f);
        }

        if (Input.GetKeyDown("d"))
        {
            transform.RotateAround(cubeTrans.position, Vector3.up, -5f);
        }

        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
