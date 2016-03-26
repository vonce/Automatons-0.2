using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SelectManager : MonoBehaviour {

    public Text selectedText;
    public UIselected selected;

    void Start()
    {
        selected = GetComponent<UIselected>();
    }

	void Update ()
    {
        if (selected.selected != null)
        {
            selectedText.text = selected.selected.name;
        }
        else
        {
            selectedText.text = "None Selected";
        }
	}
}
