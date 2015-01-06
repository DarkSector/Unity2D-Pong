using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static int PlayerScore1 = 0;
	public static int PlayerScore2 = 0;
	public GUISkin layout;
	public int threshold;
	Transform theBall;

	void Start() {
		theBall = GameObject.FindGameObjectWithTag("Ball").transform;
		//Debug.Log(theBall);
	}

	public static void Score(string WallID){
		if (WallID == "rightWall"){
			PlayerScore1++;
		} else {
			PlayerScore2++;
		}
	}

	void OnGUI(){
		int final_score =  threshold;
		GUI.skin = layout;
		GUI.Label (new Rect(Screen.width /2 -150 -12, 20, 100, 100), "" + PlayerScore1);
		GUI.Label (new Rect(Screen.width /2 +150 +12, 20, 100, 100), "" + PlayerScore2);

		if (GUI.Button(new Rect (Screen.width/2 - 60, 35, 120, 53), "RESET")){
			PlayerScore1 = 0;
			PlayerScore2 = 0;		
			theBall.gameObject.SendMessage("resetBall", 0.5f, SendMessageOptions.RequireReceiver);
		}
		if (PlayerScore1 == final_score){
			GUI.Label(new Rect(Screen.width/2 -150, 200, 2000, 1000), "Player One Wins");
			theBall.gameObject.SendMessage("hasWon", null, SendMessageOptions.RequireReceiver);

		} else if (PlayerScore2 == final_score){
			GUI.Label(new Rect(Screen.width/2 +75, 200, 2000, 1000), "Player Two Wins");
			theBall.gameObject.SendMessage("hasWon", null, SendMessageOptions.RequireReceiver);

		}
	}

}
