using UnityEngine;
using System.Collections;

public class Level3 : MonoBehaviour
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
            Application.LoadLevel("Level4");
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
