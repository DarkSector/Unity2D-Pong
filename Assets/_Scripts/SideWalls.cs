using UnityEngine;
using System.Collections;

public class SideWalls : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D hitInfo){
		if (hitInfo.transform.name == "Ball"){		
			string wallName = transform.name;
			GameManager.Score (wallName);
			hitInfo.gameObject.SendMessage("resetBall", 0.5f, SendMessageOptions.RequireReceiver);
		}
	}

}
