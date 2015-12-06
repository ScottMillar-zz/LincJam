using UnityEngine;
using System.Collections;

public class Lock : MonoBehaviour
{

    public GameObject unlock;
    public GameObject ying;
    public GameObject yang;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D()
    {
        if (ying.GetComponent<Movement>().key == true || yang.GetComponent<Movement>().key == true)
        {
            ying.GetComponent<Movement>().key = false;
            yang.GetComponent<Movement>().key = false;
            if (tag == "GameController")
            {
                ying.GetComponent<Movement>().levelUnlocked = true;
                yang.GetComponent<Movement>().levelUnlocked = true;
            }
            Destroy(unlock);
        }
    }
}