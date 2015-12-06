using UnityEngine;
using System.Collections;

public class Level4 : MonoBehaviour
{

    public bool isTriggered;
    public GameObject ying;
    public GameObject yang;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((ying.GetComponent<Movement>().levelUnlocked == true && isTriggered == true) || (yang.GetComponent<Movement>().levelUnlocked == true && isTriggered == true))
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                Application.LoadLevel("Level5");
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
