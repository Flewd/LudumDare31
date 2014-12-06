using UnityEngine;
using System.Collections;

public class bombCountDownLookat : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.LookAt(Camera.main.transform);
        gameObject.transform.Rotate(new Vector3(0, 180, 0));
	
	}
}
