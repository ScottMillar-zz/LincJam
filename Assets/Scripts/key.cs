using UnityEngine;
using System.Collections;

public class key : MonoBehaviour {

    public GameObject Key;
    public GameObject ying;
    public GameObject yang;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnCollisionEnter2D()
    {
        ying.GetComponent<Movement>().key = true;
        Debug.Log("THEY SHOULD HAVE A KEY");
        yang.GetComponent<Movement>().key = true;
        Destroy(Key);
    }
}
