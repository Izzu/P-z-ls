using UnityEngine;
using System.Collections;

public class GrabHold : MonoBehaviour {

    private GameObject anObject;
    int canGrab;
    public float range = 100f;
    Ray shootRay;
    RaycastHit hitSomething;
    //Rigidbody rigid;
    //public LineRenderer line;
    Color startColor;
    Ray ray;

    void Start()
    {
        canGrab = LayerMask.GetMask("moveable");
        //line = GetComponent<LineRenderer>();
        //line.enabled = false;
    }

	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("shoot");

            shootRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //line.enabled = true;
            //line.SetPosition(0, transform.position);
            
            if (Physics.Raycast(shootRay, out hitSomething, range))
            {
                anObject = hitSomething.collider.gameObject;
                Vector3 objectPos = anObject.transform.position;
                anObject = hitSomething.collider.gameObject;

                if (hitSomething.collider.tag == "moveable")
                {
                    startColor = anObject.GetComponent<Renderer>().material.color;

                    if (anObject.GetComponents<Rigidbody>() != null)
                        anObject.GetComponent<Rigidbody>().isKinematic = true;

                    anObject.transform.parent = Camera.main.transform;

                    //set ray color & object color
                    //line.SetColors(Color.blue, Color.blue);
                    //line.material.color = Color.blue;
                    //line.SetPosition(1, hitSomething.point);
                    anObject.GetComponent<Renderer>().material.color = Color.blue;
                }
                else
                {
                    //set ray color & object color
                    //line.SetColors(Color.red, Color.red);
                    //line.material.color = Color.red;
                }
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            if (anObject != null && anObject.GetComponent<Collider>().tag == "moveable")
            {
                anObject.GetComponent<Renderer>().material.color = startColor;
                anObject.GetComponent<Rigidbody>().isKinematic = false;
                anObject.transform.parent = null;
            }
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }        
	}
}
