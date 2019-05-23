using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AimText : MonoBehaviour {
    Text textComp;
    public float timeToClear = 2f;

	// Use this for initialization
	void Start () {
        textComp = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Print (string output)
    {
        textComp.text = "\n\n" + output;
        Invoke("ClearText", timeToClear);
    }

    void ClearText ()
    {
        textComp.text = "";
    }
}
