using UnityEngine;
using System.Collections;

public class BombScript : MonoBehaviour {

    public float timeTillExplosion;
    public float explosionRange;
    public GameObject radius;
    public GameObject ExplosionFX;
    public GameObject countDownTimer;

    float timer;
    
	// Use this for initialization
	void Start () {

        radius.transform.localScale = new Vector3(explosionRange, explosionRange, explosionRange);
        timer = timeTillExplosion;
	}
	
	// Update is called once per frame
	void Update () {

        timer -= Time.deltaTime;
        countDownTimer.GetComponent<tk2dTextMesh>().text = timer.ToString("0.#");

        if (timer <= 0)
        {
            countDownTimer.SetActive(false);
            radius.SetActive(false);

            explode();
            ExplosionFX.SetActive(true);
            GameObject.Destroy(gameObject, 2);
            timer = 99999;
        }
	}

    void explode()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");

        for (int i = 0; i < players.Length; i++)
        {
            if(Vector3.Distance(gameObject.transform.position, players[i].transform.position) <= explosionRange/2)
            {
                players[i].rigidbody.AddExplosionForce(1500, gameObject.transform.position, explosionRange);
            }
        }
    }
}
