using UnityEngine;
using System.Collections;

public class cameraControl : MonoBehaviour
{

    private Vector2 velocity;

    public float smoothTimeY;
    public float smoothTimeX;

    private float posX;
    private float posY;

    public GameObject player;

    void start ()
    {
        player = GameObject.FindWithTag("Ying");
    }

    // Update is called once per frame
    void Update()
    {

            posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX);
            posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.y, smoothTimeY);
            transform.position = new Vector3(posX, posY, transform.position.z);

        if(player.GetComponent<Movement>().paint == true)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift) && player.tag == "Yang")
            {
                player = GameObject.FindWithTag("Ying");
                Debug.Log("Camera is now on Ying");
            }
            else if (Input.GetKeyDown(KeyCode.LeftShift) && player.tag == "Ying")
            {
                player = GameObject.FindWithTag("Yang");
                Debug.Log("Camera is now on Yang");
            }
        }
    }
}