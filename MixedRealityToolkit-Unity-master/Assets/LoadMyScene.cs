using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMyScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
    SceneManager.LoadSceneAsync("testing/Scenes/Scene1", LoadSceneMode.Single);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
