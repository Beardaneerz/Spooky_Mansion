using UnityEngine;
using System.Collections;

public class AI_INPUT_MANAGER : MonoBehaviour {

	private int nJoypadConnect = 0;
	private float fTimer = 0;
	public Vector3[] v3PosArray = new Vector3[8];
	public bool[] bConnected = new bool[8];
	private GameObject player;

	void Start () {

		for (int i=0;i<8;i++){ bConnected[i] = true; }
		nJoypadConnect = this.checkJoypadConnected ();
		Debug.Log ("test");
	}
	
	int checkJoypadConnected ( ){

		int nSize = 0;
		int nID = 0;
		int i = 0;

		string[] arr = Input.GetJoystickNames ();

		while (i < arr.Length) {
			if (Input.GetJoystickNames()[i] != ""){
				nSize += 1;
				nID = i + 1;

				player = GameObject.FindWithTag("PLAYER_"+nID);

				if (!bConnected[i]){ 
					player.transform.position = new Vector3(v3PosArray [i][0],v3PosArray [i][1],v3PosArray [i][2]);
				}

				bConnected[i] = true;
			}
			else{
				if (bConnected[i]){
					nID = i + 1;
					player = GameObject.FindWithTag("PLAYER_"+nID);
					
					v3PosArray [i] = player.transform.position;
					player.transform.Translate(nID*1000, 1000, 0);

					bConnected[i] = false;
				}
			}
			i +=1;
		}

		return nSize;
	}
	
	void Update () {
		float dt = Time.deltaTime;
		fTimer += dt;

		if (fTimer > 0.5) {
			fTimer = 0;
			nJoypadConnect = this.checkJoypadConnected ();
		}
	}
}
