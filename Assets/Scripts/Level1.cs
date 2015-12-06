using UnityEngine;
using System.Collections;

public class Level1 : MonoBehaviour {

    public bool isTriggered;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (isTriggered == true)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                Application.LoadLevel("Level2");
            }
        }

	}

    void OnTriggerEnter2D()
    {
        isTriggered = true;
    }

    void OnTriggerExit2D()
    {
        isTriggered = false;
    }
}
