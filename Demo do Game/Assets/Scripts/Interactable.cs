using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum InterObject
{
    Box,
    Sphere,
    Abajur
}

public class Interactable : MonoBehaviour {
    AimText aimT;
    public InterObject objectType;


	// Use this for initialization
	void Start () {
        aimT = GameObject.Find("AimText").GetComponent<AimText>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnInteract ()
    {
        switch (objectType)
        {
            case InterObject.Box:
                aimT.Print("Don't fuck with me!");

                break;

            case InterObject.Sphere:
                aimT.Print("I wanna die!");
                break;

            case InterObject.Abajur:
                GetComponent<MorseAbajur>().RunInteraction();
                break;
        }
    }
}
