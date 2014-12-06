using UnityEngine;
using System.Collections;

public class RadiusRotationController : MonoBehaviour {

    Vector3 lookAtPos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        lookAtPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.z, 10);

        gameObject.transform.LookAt(lookAtPos);
	
	}
}
