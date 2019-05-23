using UnityEngine;

public class Aim : MonoBehaviour {
    public int range = 5;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1"))
        {
            Interact();
        }
	}

    void Interact ()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, range))
        {
            if (hit.transform.CompareTag("Interactable"))
            {
                hit.transform.GetComponent<Interactable>().OnInteract();
            } else
            {
                Debug.Log("Nothing to do here!");
            }
        }
    }
}
