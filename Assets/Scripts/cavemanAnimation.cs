using UnityEngine;
using System.Collections;

public class cavemanAnimation : MonoBehaviour {

    Animator anim;
    Movement movement;
    bool move = false;
    bool painted = false;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per fdrame
	void Update () {


        if (Input.GetKey(KeyCode.D))
        {
            move = true;
            anim.SetBool("moveRight", move);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            move = true;
            anim.SetBool("moveLeft", move);
        }
        else
        {
            move = false;
            move = false;
            anim.SetBool("moveLeft", move);
            anim.SetBool("moveRight", move);
        }
        if (GetComponent<Movement>().paint == true)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                if (painted == false)
                {
                    painted = true;
                    anim.SetBool("painted", painted);
                }
                else
                {
                    painted = false;
                    anim.SetBool("painted", painted);
                }
            }
        }
        

  

    }
}
