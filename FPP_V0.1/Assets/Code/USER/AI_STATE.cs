/***********************************************\
 * Author : Arnaud Mollé
 * Date : 11/05/16
 * Description : Cet AI permet de recréer une state machine pour n'importe quel type de gameObject
 * Il suffit de renseigner un "sState" et de lui donner les comportements voulus
\***********************************************/

using UnityEngine;
using System.Collections;

public class AI_STATE : MonoBehaviour {

	private string sState = ""; // STATE ACTUELLE
	private bool bState = true; // SECURITE SI LA STATE NE FAIT RIEN DANS L'ENTERFRAME

	void Start () {
		// INITIALISATION EN IDLE
		this.changeState ("IDLE");
	}

	void changeState ( string sNewState ){

		// SECURITE : IMPOSSIBLE DE CHANGER DE STATE QUAND ON EST DANS LA MEME STATE
		if (sNewState != sState) {

			// SECURITE : 
			// FIN DE L'ANCIENNE STATE
			if (sState != "") {

				this.endState ();
			}

			bState = true;
			sState = sNewState;

			this.beginState ();
		}
	}

	// EXECUTION 1 FOIS EN DEBUT
	void beginState (){

		Debug.Log("Begin_"+sState);

		if (sState == "IDLE"){
			bState = false;
		}
		else if (sState == "LAUNCH"){
			
		}
	}

	// EXECUTION CHAQUE FRAME
	void updateState (){

		if (sState == "IDLE"){

		}
		else if (sState == "LAUNCH"){
			
		}
	}

	// EXECUTION 1 FOIS EN FIN
	void endState (){

		Debug.Log("End_"+sState);

		if (sState == "IDLE"){
		
		}
		else if (sState == "LAUNCH"){

		}
	}

	void Update () {

		if (bState){ 

			this.updateState ();
		}
	}
}
