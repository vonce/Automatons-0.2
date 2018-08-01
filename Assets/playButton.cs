using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playButton : MonoBehaviour {

    public CanvasRenderer button;

    // Use this for initialization
    void Start ()
    {
        button.GetComponent<Button>().onClick.AddListener(buttonPress);
    }
	
    void buttonPress ()
    {
        SceneManager.LoadScene("game", LoadSceneMode.Single);
    }

	// Update is called once per frame
	void Update ()
    {
		
	}
}
