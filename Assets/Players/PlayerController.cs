using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour {

    private Vector3 currentVector;

    [Tooltip ("Controls the speed of player movement, defaults to 5.")]
    public float playerSpeed = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isLocalPlayer) {
            TranslatePosition();
        }
    }

    private void TranslatePosition() {
        currentVector.x = CrossPlatformInputManager.GetAxis("Horizontal") * Time.deltaTime * playerSpeed;
        currentVector.y = 0f;
        currentVector.z = CrossPlatformInputManager.GetAxis("Vertical") * Time.deltaTime * playerSpeed;
        transform.Translate(currentVector);
    }
}
