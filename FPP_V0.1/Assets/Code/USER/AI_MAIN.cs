/***********************************************\
 * Author : Arnaud Mollé
 * Date : 11/05/16
\***********************************************/

using UnityEngine;
using System.Collections;

public class AI_MAIN : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}


	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")){

			SendMessage("changeState", "LAUNCH" );
		}
	}
}
