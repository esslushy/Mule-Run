using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	// Use this for initialization
	public GameObject player;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = player.transform.position + new Vector3(0, transform.position.y, 0);
	}
}
