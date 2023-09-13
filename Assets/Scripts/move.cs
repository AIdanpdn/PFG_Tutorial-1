using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1move : MonoBehaviour
{
    //Script is used for blue movement

    public float moveSpeed = 10f;
    public float jumpSpeed = 15f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //GetKey for inputs, transform for player movement

        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.up * jumpSpeed * Time.deltaTime);
    }
}