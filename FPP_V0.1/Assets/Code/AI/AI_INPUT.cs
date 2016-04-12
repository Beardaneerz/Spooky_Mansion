/***********************************************\
 * Author : Arnaud Mollé
 * Date : 12/05/16
 * Description : A mettre sur le personnage puis lui adjoidnre un ID qui sera connecté aux ID d'input
\***********************************************/

using UnityEngine;
using System.Collections;

public class AI_INPUT : MonoBehaviour {

	public int nID = 0;

	private float nXLeft = 0.0F;
	private float nYLeft = 0.0F;

	void Start () {
	
	}

	void Move () {

		this.gameObject.transform.position += new Vector3 (nXLeft, nYLeft, 0);
	}

	void Update () {
	
		if (Input.GetAxis ("AXIS_X_1_" + nID) != 0) {
			Debug.Log ("player : " + nID + " AxisX : " + Input.GetAxis ("AXIS_X_1_" + nID));
			nXLeft = Input.GetAxis ("AXIS_X_1_" + nID);
		} 
		else {
			nXLeft = 0;
		}

		if (Input.GetAxis ("AXIS_Y_1_"+nID)!= 0){
			Debug.Log ("player : "+ nID + " AxisY : " + Input.GetAxis ("AXIS_Y_1_"+nID));
			nYLeft = Input.GetAxis ("AXIS_Y_1_"+nID);
		}
		else {
			nYLeft = 0;
		}

		this.Move ();

	}
}
