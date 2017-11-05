using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Input_Controller : MonoBehaviour {

    public GameObject leftBat;
    public GameObject rightBat;
    public float speed = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        rightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        if (Input.GetKey(KeyCode.W))
        {
            //Debug.Log("pressed W");
            leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, speed, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //Debug.Log("pressed S");
            leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, -speed, 0f);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Debug.Log("pressed UpArrow");
            rightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, speed, 0f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //Debug.Log("pressed DownArrow");
            rightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, -speed, 0f);
        }
    }
}
