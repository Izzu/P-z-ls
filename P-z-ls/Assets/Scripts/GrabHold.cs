using UnityEngine;
using System.Collections;

public class GrabHold : MonoBehaviour {

    private GameObject anObject;
    int canGrab;
    public float range = 100f;
    Ray shootRay;
    RaycastHit hitSomething;
    //Rigidbody rigid;

    void Start()
    {
        canGrab = LayerMask.GetMask("moveable");
    }

	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("shoot");

            shootRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (Physics.Raycast(shootRay, out hitSomething, range))
            {
                anObject = hitSomething.collider.gameObject;
                Vector3 objectPos = anObject.transform.position;
                Debug.Log("hit something");

                if (hitSomething.collider.tag == "moveable")
                {
                    Debug.Log("hit something moveable");

                    if (anObject.GetComponents<Rigidbody>() != null)
                        anObject.GetComponent<Rigidbody>().isKinematic = true;

                    anObject.transform.parent = Camera.main.transform;
                }
            }
            else
                Debug.Log("nothing hit");
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("drop it");
            anObject.GetComponent<Rigidbody>().isKinematic = false;
            anObject.transform.parent = null;
        }
        else if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }
	}
}
