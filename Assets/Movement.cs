using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
		
	public float speed = 4f;
	public float jumpHeight;
	public bool isJumping = false;
	public bool wallJump = false;
	public bool onWall = false;
		
		void start()
	{
	}

		// Update is called once per frame
		void Update () 
		{
			
			if (Input.GetKey (KeyCode.D)) {
				transform.Translate(Vector2.right * speed * Time.deltaTime);    
			}
			else if (Input.GetKey (KeyCode.A)) {
				transform.Translate(-Vector2.right * speed * Time.deltaTime);   
			}
			else if (Input.GetKey (KeyCode.S)) {
				transform.Translate(-Vector2.up * speed * Time.deltaTime);  
			}
			if (Input.GetKeyDown (KeyCode.Space)) 
			{
				if (isJumping == false)
				{
					GetComponent<Rigidbody2D> ().velocity = Vector2.up * jumpHeight;

					isJumping = true;

				}
				else if(onWall == true && wallJump == false)
				{
					GetComponent<Rigidbody2D> ().velocity = Vector2.up * jumpHeight;
					wallJump = true;
				}
			}
		}
		


		void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Ground") 
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