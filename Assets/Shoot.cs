using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	private Vector3 mouse_pos;
	private Vector3 object_pos;
	private float angle;
	private float bulletSpeed = 20;
	public GameObject bulletPrefab;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate () {
		if (Input.GetMouseButtonDown (0))
		{
			mouse_pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector2 dir = new Vector2(mouse_pos.x - transform.position.x, mouse_pos.y - transform.position.y);
			dir.Normalize();

			GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.identity);
			bullet.transform.eulerAngles = new Vector3(0, 0, Mathf.Atan2((mouse_pos.y - transform.position.y), (mouse_pos.x - transform.position.x)) * Mathf.Rad2Deg);
			bullet.GetComponent<Rigidbody2D>().velocity = dir * bulletSpeed;
		}
	}
}


