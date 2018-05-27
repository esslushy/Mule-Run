using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Movement : MonoBehaviour {

	// Use this for initialization
	float speed;
	float angle = 0;
	Rigidbody rigidbody;
	private Vector3 mousePosition;
	private Vector3 object_pos;
	bool firstTime = true;
	void Start () {
		speed = .1f;
		rigidbody = GetComponent<Rigidbody>();
		StartCoroutine("increaseSpeed");
		StartCoroutine("WinCondition");
	}
	
	// Update is called once per frame
	void Update () {
		movement();
	}

	private void movement ()
    {
		transform.position += (transform.forward * speed);
		rotate();
    }
	private IEnumerator increaseSpeed(){
		while(true){
			speed+=.02f;
			print("speeding up");
			yield return new WaitForSeconds(15f);
		}
	}
	private void rotate(){
		if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)){
			transform.Rotate(0, -3,0 );
		}else if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)){
			transform.Rotate(0, 3, 0);
		}
	}

	private IEnumerator WinCondition(){
		while(true){
			if (firstTime){
				Debug.Log("works");
				yield return new WaitForSeconds(180f);
				firstTime = false;
			}else{
				SceneManager.LoadScene("Win Screen");
				yield return null;
			}
		}
	}
	
}
