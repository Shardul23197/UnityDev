using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hey");
    }

    // Update is called once per frame
    void Update()
    {
        //Increase or decrease x position with A/D
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0.001f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(-0.001f, 0f, 0f);
        }

        //Increase or decrease y position with W/S
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0.001f, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, -0.001f, 0f);
        }

        //Increase or decrease z position with Q/E
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(0f, 0f, 0.001f);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(0f, 0f, -0.001f);
        }
    }
}
