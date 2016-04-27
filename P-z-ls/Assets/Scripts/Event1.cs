using UnityEngine;
using System.Collections;

public class Event1 : MonoBehaviour {

    private int count;
    public GameObject particles;

	// Use this for initialization
	void Start () {
        count = 0;
        particles.SetActive(false);
	}
	
	void OnTriggerEnter(Collider other)
    {
        count++;
        Debug.Log(count);

        if(count == 5)
        {
            particles.SetActive(true);
        }
    }
}
