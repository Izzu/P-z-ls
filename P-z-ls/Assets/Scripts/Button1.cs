﻿using UnityEngine;
using System.Collections;

public class Button1 : MonoBehaviour {

    public GameObject particles;
    public GameObject button;
    Vector3 buttonStart;
    Vector3 buttonEnd;
    Vector3 start;
    Vector3 end;

    // Use this for initialization
    void Start () {
        particles.SetActive(false);
        buttonStart = button.transform.position;
        buttonEnd = buttonStart - new Vector3(0f, 30f, 0f);
        start = gameObject.transform.position;
        end = start - new Vector3(0f, 5f, 0f);
	}
	
    //on collision do this
	void OnCollisionEnter(Collision other)
    {
        float speed = Time.deltaTime * 10;
        gameObject.transform.position = Vector3.Lerp(start, end, speed);
        button.transform.position = Vector3.Lerp(start, end, speed);
        //button.transform.position = button.transform.position - new Vector3(0f, 5f, 0f);
        particles.SetActive(true); //start the particle effects
    }

    void OnCollisionExit(Collision other)
    {
        float speed = Time.deltaTime * 10;
        gameObject.transform.position = Vector3.Lerp(end, start, speed);
        button.transform.position = Vector3.Lerp(end, start, speed);
        particles.SetActive(false);
    }
}
