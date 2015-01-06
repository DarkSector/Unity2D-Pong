using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {

	public KeyCode moveUp;
	public KeyCode moveDown;

	public float speed = 10.0f;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(moveUp)){
			var vel = rigidbody2D.velocity;
			vel.y = speed;
			rigidbody2D.velocity = vel;
		}
		else if (Input.GetKey(moveDown)){
			var vel = rigidbody2D.velocity;
			vel.y = speed * -1;
			rigidbody2D.velocity = vel;
		}
		else{
			var vel = rigidbody2D.velocity;
			vel.y = 0.0f;
			rigidbody2D.velocity = vel;
		}
	}
}
