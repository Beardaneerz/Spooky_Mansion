/***********************************************\
 * Author : Arnaud Mollé
 * Date : 11/05/16
 * Use : Attacher à une cam
\***********************************************/

using UnityEngine;
using System.Collections;

public class AI_CAM : MonoBehaviour {

	public float nX = 0;
	public float nAmplitude = 0F;

	private bool bShakeScreen = false;
	private float nTimerShake = 0;
	private float nTimerShakeMax = 0.02F;
	private float nSensShake = 1;

	void Start () {
	
	}

	void screenShake ( ){

		float dt = Time.deltaTime;

		if (nTimerShake < -nTimerShakeMax) {
			nSensShake = 1;
			nTimerShakeMax = Random.Range (0.01F,0.05F);
		}
		if (nTimerShake > nTimerShakeMax) {
			nSensShake = -1;
			nTimerShakeMax = Random.Range (-0.01F,-0.05F);
		}

		nX += dt * nAmplitude * nSensShake;
		nTimerShake += dt * nSensShake;

		this.gameObject.transform.position = new Vector3(nX,0,0);
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("space")){

			bShakeScreen = true;
		}

		if ( Input.GetKeyUp("space")){

			bShakeScreen = false;
			nX = 0;
			this.gameObject.transform.position = new Vector3(0,0,0);

		}

		if ( bShakeScreen ){
			this.screenShake ( );
		}
	}
}
