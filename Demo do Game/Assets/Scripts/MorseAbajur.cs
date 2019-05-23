using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorseAbajur : MonoBehaviour {
    public float unitTime = 1;
    public List<bool> msg;
    int currentIndex = 0;
    Renderer rnd;
    public Material onMaterial;
    public Material offMaterial;
    Light lit;

    private void Start()
    {
        rnd = transform.GetChild(1).GetComponent<Renderer>();
        lit = gameObject.GetComponent<Light>();

        msg.Add(true);
        msg.Add(false);
        msg.Add(true);
        msg.Add(false);
        msg.Add(true);
        msg.Add(true);
        msg.Add(false);
        msg.Add(false);
        msg.Add(true);
        msg.Add(true);
        msg.Add(false);
        msg.Add(true);
        msg.Add(true);
        msg.Add(false);
        msg.Add(false);
        msg.Add(false);
        msg.Add(true);
        msg.Add(true);
        msg.Add(false);
        msg.Add(true);
        msg.Add(true);
        msg.Add(false);
        msg.Add(true);
        msg.Add(false);
        msg.Add(true);
        msg.Add(true);
        msg.Add(false);
        msg.Add(false);
        msg.Add(true);
        msg.Add(false);
        msg.Add(true);
        msg.Add(false);
        msg.Add(true);
        msg.Add(true);
        msg.Add(false);
        msg.Add(false);
        msg.Add(true);
        msg.Add(false);
        msg.Add(true);
        msg.Add(true);
        msg.Add(false);
        msg.Add(false);
        msg.Add(true);
        msg.Add(true);
        msg.Add(false);
        msg.Add(false);
        msg.Add(true);
        msg.Add(false);
        msg.Add(true);
        msg.Add(true);
        msg.Add(false);
        msg.Add(true);
        msg.Add(false);
        msg.Add(false);
        msg.Add(true);
        msg.Add(true);
        msg.Add(false);
        msg.Add(true);
        msg.Add(true);
        msg.Add(false);
        msg.Add(true);
        msg.Add(true);
        msg.Add(false);
    }

    public void RunInteraction()
    {
        InvokeRepeating("Beep", 0, unitTime);
    }

    void Beep()
    {
        if (currentIndex < msg.Count)
        {
            rnd.material = msg[currentIndex] ? onMaterial : offMaterial;
            lit.intensity = msg[currentIndex] ? 1 : 0;
            currentIndex ++;
        }
        else
        {
            currentIndex = 0;
            CancelInvoke();
        }
    }
}
