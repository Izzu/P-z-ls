﻿using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);
	}

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
	
}
