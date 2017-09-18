using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Key : MonoBehaviour {

	public string level; 

	private SpriteRenderer Sprite; 

	private bool isPressed = false;
	// Use this for initialization
	void Start () {
		Sprite = gameObject.GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		Pressed ();
	}

	void OnMouseDown(){
		isPressed = true;
	}

	void OnMouseUp(){
		isPressed = false;
	}

	void Pressed() {
		if (isPressed) {
			Vector2 MousePosition = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
			Vector2 objPosition = Camera.main.ScreenToWorldPoint (MousePosition);
			transform.position = objPosition; 
		}
	}

	void OnCollisionEnter2D (Collision2D coll){
		if (coll.gameObject.tag == "Keyhole") {
			Debug.Log ("help");
			//Application.LoadLevel (1);
			SceneManager.LoadScene(Random.Range(1,4));
		}
	}
}


