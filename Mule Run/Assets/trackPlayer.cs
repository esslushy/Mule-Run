using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class trackPlayer : MonoBehaviour {

	// Use this for initialization
	public GameObject player;
	float speed;
	Collider catchCollider;
	void Start () {
		speed = .096f;
		StartCoroutine("increaseSpeed");
		catchCollider = GetComponent<SphereCollider>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(player.transform);
		transform.position += transform.forward * speed;
		
	}
	private IEnumerator increaseSpeed(){
		while(true){
			speed+=.02f;
			print("speeding up");
			yield return new WaitForSeconds(15f);
		}
	}
	void OnTriggerEnter(Collider other) {
		if(other.tag == "Player"){
        	loseLoad();
		}
    }
	public void loseLoad(){
		SceneManager.LoadScene("Lose scene");
	}
	
}
