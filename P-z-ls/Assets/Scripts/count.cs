using UnityEngine;
using System.Collections;

public class count : MonoBehaviour {

    public int counter;
    //public GameObject particles;

	// Use this for initialization
	void Start () {
        counter = 0;
        //particles.SetActive(false);
	}

    void Update()
    {
        if (counter == 4)
        {
            //particles.SetActive(true);
        }
        //else
            //particles.SetActive(false);
    }
}
