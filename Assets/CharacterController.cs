using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

    public int player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if(player == 1)
        {
            if (Input.GetKey(KeyCode.W))
            {
                rigidbody.AddForce(0, 0, 20);
            }
            if (Input.GetKey(KeyCode.S))
            {
                rigidbody.AddForce(0, 0, -20);
            }
            if (Input.GetKey(KeyCode.A))
            {
                rigidbody.AddForce(-20, 0, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                rigidbody.AddForce(20, 0, 0);
            }
        }

        else if (player == 2)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rigidbody.AddForce(0, 0, 20);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                rigidbody.AddForce(0, 0, -20);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rigidbody.AddForce(-20, 0, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rigidbody.AddForce(20, 0, 0);
            }
        }
	
	}
}
