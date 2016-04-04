using UnityEngine;
using System.Collections;

public class Highlight : MonoBehaviour {

    private Color startcolor;

    void OnMouseEnter()

    {
        //startcolor = renderer.material.color;
        startcolor = GetComponent<Renderer>().material.color;
        //renderer.material.color = Color.red;
        GetComponent<Renderer>().material.color = new Color(0.09f, 0.75f, 0.75f, 0.75f);
    }
    void OnMouseExit()
    {
        //renderer.material.color = startcolor;
        GetComponent<Renderer>().material.color = startcolor;
    }
}
