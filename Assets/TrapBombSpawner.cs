using UnityEngine;
using System.Collections;

public class TrapBombSpawner : MonoBehaviour {

    public GameObject floor;

    public GameObject width1;
    public GameObject width2;
    public GameObject height1;
    public GameObject height2;

    float timeBetweenBombs = 0.5f;

    float timer = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        timer += Time.deltaTime;

        if (timer >= timeBetweenBombs)
        {
            GameObject bomb = Instantiate(Resources.Load("bomb", typeof(GameObject))) as GameObject;
            bomb.transform.position = new Vector3(Random.Range(width1.transform.position.x/2, width2.transform.position.x/2), 20, Random.Range(height1.transform.position.z, height2.transform.position.z));
            timer = 0;
        }
	
	}
}
