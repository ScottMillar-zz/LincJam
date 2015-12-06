using UnityEngine;
using System.Collections;

public class paintEnable : MonoBehaviour {

    public GameObject player;

	void Start () {
	
	}
	
	
	void Update () {
            
	}

    void onTriggerEnter()
    {
        player.GetComponent<Movement>().paint = true;
        Debug.Log("Ying has paint.");
    }
}
