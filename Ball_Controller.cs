using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Controller : MonoBehaviour {

    Rigidbody rb;

	// Use this for initialization
	void Start () {
        // Choose x axis direction
        int xDirection = Random.Range(0, 2);

        // Chose y axis directions
        int yDirection = Random.Range(0, 2);

        // Initialize movement vector
        Vector3 launchDirection = new Vector3();

        // Chose launch direction in x axis
        if (xDirection == 0)
        {
            launchDirection.x = -8f;
        }
        if (xDirection == 1)
        {
            launchDirection.x = 8f;
        }
        if (yDirection == 2)
        {
            launchDirection.x = 0f;
        }

        // Choose launch direction in y axis
        if (yDirection == 0)
        {
            launchDirection.y = -8f;
        }
        if (yDirection == 1)
        {
            launchDirection.y = 8f;
        }
        if (yDirection == 2)
        {
            launchDirection.y = 0f;
        }
         rb = GetComponent<Rigidbody>();
         rb.velocity = new Vector3(launchDirection.x, launchDirection.y, 0f);
	}

    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.name == "Top_Box_Collider")
        {
            //Debug.Log("Top_Box_Collider");
            //float speedDirectionX=8f;
            if (rb.velocity.x > 0)
            {
                rb.velocity = new Vector3(8f, 8f, 0f);
            }
            if (rb.velocity.x < 0)
            {
                rb.velocity = new Vector3(-8f, 8f, 0f);
            }
            Debug.Log("Hit an object!");
            Debug.Log(hit.gameObject.name);
            // rb.velocity = new Vector3(speedDirectionX, 8f, 0f);
        }
        if (hit.gameObject.name == "Bottom_Box_Colider")
        {
            //Debug.Log("Bottom_Box_Collider");
            //float speedDirectionX = 0f;
            if (rb.velocity.x > 0)
            {
                rb.velocity = new Vector3(8f, 8f, 0f);
            }
            if (rb.velocity.x < 0)
            {
                rb.velocity = new Vector3(-8f, 8f, 0f);
            }
            Debug.Log("Hit an object!");
            Debug.Log(hit.gameObject.name);
            //rb.velocity = new Vector3(speedDirectionX, 8f, 0f);
        }

        if (hit.gameObject.name == "Left_Bat")
            {
                Debug.Log("hit left bat");
                // Ball hit upper half of a bat
                if ((transform.position.y - hit.gameObject.transform.position.y) > 0)
                    {
                    rb.velocity = new Vector3(8f, 8f, 0f);
                    }
                // Ball hit lower half of bat
                if ((transform.position.y - hit.gameObject.transform.position.y) < 0)
                    {
                    rb.velocity = new Vector3(8f, -8f, 0f);
                    }
                 // Ball hit center of bat
                if ((transform.position.y - hit.gameObject.transform.position.y) ==0 )
                    {
                    rb.velocity = new Vector3(8f, 8f, 0f);
                    }
        }
        if (hit.gameObject.name == "Right_Bat")
            {
            Debug.Log("hit left bat");
            // Ball hit upper half of a bat
            if ((transform.position.y - hit.gameObject.transform.position.y) >= 1)
            {
                rb.velocity = new Vector3(-8f, 8f, 0f);
            }
            // Ball hit upper half of bat
            if ((transform.position.y - hit.gameObject.transform.position.y) < 1)
            {
                rb.velocity = new Vector3(-8f, -8f, 0f);
            }
            // Ball hit center of bat
            if ((transform.position.y - hit.gameObject.transform.position.y) == 0)
            {
                rb.velocity = new Vector3(-8f, 8f, 0f);
            }
        }
    }

    // Update is called once per frame
    void Update () {
		if (Input.GetKey(KeyCode.Space))
        {
            // fliopa a coin
            // if statement
            if (rb.velocity.x >= 0)
            {
                if (rb.velocity.y >= 0)
                {
                    rb.velocity = new Vector3(8f, 8f, 0f);
                }
                else
                {
                    rb.velocity = new Vector3(8f, -8f, 0f);
                }
            }
            if (rb.velocity.x < 0)
            {
                if (rb.velocity.y >= 0)
                {
                    rb.velocity = new Vector3(-8f, 8f, 0f);
                }
                else
                {
                    rb.velocity = new Vector3(-8f, -8f, 0f);
                }
            }
        }
	}
}
