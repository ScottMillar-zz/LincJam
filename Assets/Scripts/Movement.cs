using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
		
	public float speed = 4f;
	public float jumpHeight;
	public bool isJumping = false;
	public bool wallJump = false;
	public bool onWall = false;
    public bool painted = false;
    public bool paint = false;
    public bool enableR = false;

		
		void start()
	{
	}

		// Update is called once per frame
		void Update ()
        {

        if (paint == true)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift) && painted == true)
            {
                painted = false;
                GetComponent<Rigidbody2D>().gravityScale = 1;
                GetComponent<Rigidbody2D>().mass = 1;

            }
            else if (Input.GetKeyDown(KeyCode.LeftShift) && painted == false)
            {
                painted = true;
                GetComponent<Rigidbody2D>().gravityScale = 0;
                GetComponent<Rigidbody2D>().mass = 1000000;
                GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            }
        }

        if (painted == false)
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(-Vector2.right * speed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(-Vector2.up * speed * Time.deltaTime);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (isJumping == false)
                {
                    GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpHeight;

                    isJumping = true;

                }
                else if (onWall == true && wallJump == false)
                {
                    GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpHeight;
                    wallJump = true;
                }
            }


            if(Input.GetKeyDown(KeyCode.R))
            {
                if (enableR == true)
                {
                    Application.LoadLevel(Application.loadedLevel);
                } 
            }
        }

        
        
    }
		


		void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Ground" || col.gameObject.tag == "Ying" || col.gameObject.tag == "Yang") 
		{
			isJumping = false;
			wallJump = false;
		}

		if (col.gameObject.tag == "Wall") 
		{
			onWall = true;
		}
	}


		void OnCollisionExit2D(Collision2D col)
	{
		if (col.gameObject.tag == "Wall") 
		{
			onWall = false;
		}
	}
}