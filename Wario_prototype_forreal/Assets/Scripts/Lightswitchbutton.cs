using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lightswitchbutton : MonoBehaviour {

	public void changeMenuScene(string sceneName){
	
		SceneManager.LoadScene(Random.Range(2,4));
	}

}
