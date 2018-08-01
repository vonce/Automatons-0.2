using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour {

    public Text win;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnDestroy ()
    {

        SceneManager.LoadScene("Splash Screen", LoadSceneMode.Single);
    }
}
