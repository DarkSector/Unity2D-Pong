using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke("goBall", 1.0f);
	}
	
	void goBall(){
		float rand = Random.Range(0.0f, 30.00f);
		rigidbody2D.AddForce(new Vector2(15.00f, rand));
	}

	void hasWon(){
		var vel = rigidbody2D.velocity;
		vel.y = 0;
		vel.x = 0;
		rigidbody2D.velocity = vel;
		gameObject.transform.position = new Vector2(0, 0);
	}

	void resetBall(){
		var vel = rigidbody2D.velocity;
		vel.y = 0;
		vel.x = 0;
		rigidbody2D.velocity = vel;
		gameObject.transform.position = new Vector2(0, 0);
		Invoke("goBall", 1.0f);
	}

	void OnCollisionEnter2D(Collision2D coll){
		if(coll.collider.CompareTag("Player")){
			var velY = rigidbody2D.velocity;
			velY.y = (velY.y/2.0f)+(coll.collider.rigidbody2D.velocity.y/3.0f);
			rigidbody2D.velocity = velY;
		}
	}
}
