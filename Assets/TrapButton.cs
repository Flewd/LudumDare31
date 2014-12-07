using UnityEngine;
using System.Collections;

public class TrapButton : MonoBehaviour {


    public GameObject trapBombSpawner;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            trapBombSpawner.SetActive(true);
            iTween.MoveTo(gameObject, gameObject.transform.position - new Vector3(0,5,0),1);
            StartCoroutine(moveButtonBack());
        }
    }

    IEnumerator moveButtonBack()
    {
        yield return new WaitForSeconds(5);
        iTween.MoveTo(gameObject, gameObject.transform.position + new Vector3(0, 5, 0), 1);
        trapBombSpawner.SetActive(false);
    }
}
