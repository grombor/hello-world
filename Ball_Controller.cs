using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball_Controller : MonoBehaviour {

    Rigidbody rb;
    public float ballSpeed = 10f;


	// Use this for initialization
	void Start () {

        // Initialize rigidbody component
        rb = GetComponent<Rigidbody>();

        // Adding some delay to the ball
        StartCoroutine(Pause());

	}

    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.name == "Top_Box_Collider")
        {
            //Debug.Log("Top_Box_Collider");
            //float speedDirectionX=8f;
            if (rb.velocity.x > 0)
            {
                rb.velocity = new Vector3(ballSpeed, ballSpeed, 0f);
            }
            if (rb.velocity.x < 0)
            {
                rb.velocity = new Vector3(-ballSpeed, ballSpeed, 0f);
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
                rb.velocity = new Vector3(ballSpeed, ballSpeed, 0f);
            }
            if (rb.velocity.x < 0)
            {
                rb.velocity = new Vector3(-ballSpeed, ballSpeed, 0f);
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
                    rb.velocity = new Vector3(ballSpeed, ballSpeed, 0f);
                    }
                // Ball hit lower half of bat
                if ((transform.position.y - hit.gameObject.transform.position.y) < 0)
                    {
                    rb.velocity = new Vector3(ballSpeed, -ballSpeed, 0f);
                    }
                 // Ball hit center of bat
                if ((transform.position.y - hit.gameObject.transform.position.y) ==0 )
                    {
                    rb.velocity = new Vector3(ballSpeed, ballSpeed, 0f);
                    }
        }
        if (hit.gameObject.name == "Right_Bat")
            {
            Debug.Log("hit left bat");
            // Ball hit upper half of a bat
            if ((transform.position.y - hit.gameObject.transform.position.y) >= 1)
            {
                rb.velocity = new Vector3(-ballSpeed, ballSpeed, 0f);
            }
            // Ball hit upper half of bat
            if ((transform.position.y - hit.gameObject.transform.position.y) < 1)
            {
                rb.velocity = new Vector3(-ballSpeed, -ballSpeed, 0f);
            }
            // Ball hit center of bat
            if ((transform.position.y - hit.gameObject.transform.position.y) == 0)
            {
                rb.velocity = new Vector3(-ballSpeed, ballSpeed, 0f);
            }
        }
    }

    // Update is called once per frame
    void Update () {

        // Check if ball is too far to left
        if (transform.position.x <= -20f)
        {
            // Give player 1 a point
            Scoreboard_Controller.instance.pOneScorePoint();

            //Reset a ball
            StartCoroutine(Pause());

        }

        // Check if ball is too far to right
        if (transform.position.x >= 20f)
        {
            
            // Give player 2 a point
            Scoreboard_Controller.instance.pTwoScorePoint();

            // Reset a ball
            StartCoroutine(Pause());
        }
        // go to menu
        if (Input.GetKey(KeyCode.Escape))
          {
            SceneManager.LoadScene(0);
        }
    }

    void LaunchBall()
    {

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
        if (yDirection > 1)
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
        if (yDirection > 1)
        {
            launchDirection.y = 0f;
        }
      
        rb.velocity = new Vector3(launchDirection.x, launchDirection.y, 0f);
    }


    IEnumerator Pause()
    {
        // Setting speed to 0
        rb.velocity = new Vector3(0, 0, 0);

        // Setting up ball position to center of the screen
        transform.position = new Vector3(0,0,0);

        // Delay
        yield return new WaitForSeconds(3f);
        // Launch the Ball
        LaunchBall();
    }

}
