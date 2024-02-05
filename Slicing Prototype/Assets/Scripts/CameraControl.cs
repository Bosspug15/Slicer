using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraControl : MonoBehaviour
{

    private Transform trans;
    private float dirX = 0f;
    [SerializeField] private Transform cubeTrans;

    // Start is called before the first frame update
    void Start()
    {
        trans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");

            transform.RotateAround(cubeTrans.position, Vector3.up, dirX * 0.1f);

        

        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene("Main");
        }
    }
}
