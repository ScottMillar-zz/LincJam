using UnityEngine;
using System.Collections;

public class cavemanAnimation : MonoBehaviour {

    Animator anim;
    float move = 0;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per fdrame
	void Update () {


        while (Input.GetKeyDown(KeyCode.D))
        {
            move = 1;
            anim.SetFloat("Speed", move);           
        }

    }
}
