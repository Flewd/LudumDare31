using UnityEngine;
using System.Collections;

public class BombSpawner : MonoBehaviour {

    public GameObject floor;
    public float timeBetweenBombs;

    float timer = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;

        if (timer >= timeBetweenBombs)
        {
            GameObject instance = Instantiate(Resources.Load("bomb", typeof(GameObject))) as GameObject;
            instance.transform.position = new Vector3(Random.Range(-floor.transform.localScale.x / 4, floor.transform.localScale.x / 4), 20, Random.Range(-floor.transform.localScale.z / 4, floor.transform.localScale.z / 4));
            timer = 0;
        }
	
	}
}
