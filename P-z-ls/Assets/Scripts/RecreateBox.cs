using UnityEngine;
using System.Collections;

public class RecreateBox : MonoBehaviour {

    public GameObject box;
    GameObject clone;

	void OnTriggerEnter()
    {
        clone = (GameObject)Instantiate(box, new Vector3(0.5857982f, 0.9108105f, -8.68f), Quaternion.identity);
        clone.GetComponent<Renderer>().material.color = Color.white;
    }
}
