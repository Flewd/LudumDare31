using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

    public int player;
    public GameObject weapon;

    float punchReset = 0.25f;
    float punchCooldown = 0;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        punchCooldown -= Time.deltaTime;

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

            if (punchCooldown <= 0)
            {
                if (Input.GetKey(KeyCode.I))
                {
                    spawnProjectile(new Vector3(0, 0, 1));
                }
                else if (Input.GetKey(KeyCode.K))
                {
                    spawnProjectile(new Vector3(0, 0, -1));
                }
                else if (Input.GetKey(KeyCode.J))
                {
                    spawnProjectile(new Vector3(-1, 0, 0));
                }
                else if (Input.GetKey(KeyCode.L))
                {
                    spawnProjectile(new Vector3(1, 0, 0));
                }
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

    void spawnProjectile(Vector3 direction)
    {
        GameObject projectile = Instantiate(Resources.Load("weapon", typeof(GameObject))) as GameObject;
        projectile.transform.position = gameObject.transform.position + direction;
        projectile.rigidbody.AddForce(1500 * direction.x, 0, 1500 * direction.z);
        punchCooldown = punchReset;

        if (direction.z == 0)
        {
            projectile.transform.Rotate(0, 90, 0);
        }

        GameObject.Destroy(projectile, 0.35f);
    }
}
