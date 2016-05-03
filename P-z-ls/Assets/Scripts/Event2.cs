using UnityEngine;
using System.Collections;

public class Event2 : MonoBehaviour {

    public int weight;
    public GameObject particles;

	// Use this for initialization
	void Start () {
        particles.SetActive(false);
	}
	
	void OnCollisionEnter(Collision other)
    {
        //if(other.rigidbody.mass == weight)
        //{
            gameObject.transform.position = gameObject.transform.position - new Vector3(0f, 0.01f, 0f);
            particles.SetActive(true);
        //}
    }
}
