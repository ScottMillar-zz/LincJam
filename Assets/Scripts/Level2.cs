using UnityEngine;
using System.Collections;

public class Level2 : MonoBehaviour
{

    public bool isTriggered;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Application.LoadLevel("Level3");
        }

    }

    void onTriggerEnter()
    {
        isTriggered = true;
    }

    void onTriggerExit()
    {
        isTriggered = false;
    }
}
