using UnityEngine;
using System.Collections;

public class EnableRTS : MonoBehaviour {

	// Use this for initialization
	void Start () {
        (GetComponent("LeapRTS") as MonoBehaviour).enabled = false;
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "hand")
            (GetComponent("LeapRTS") as MonoBehaviour).enabled = true;
        else
            (GetComponent("LeapRTS") as MonoBehaviour).enabled = false;
    }
}
