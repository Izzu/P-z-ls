using UnityEngine;
using System.Collections;

public class GrabHold : MonoBehaviour {
    GameObject grabbedObject;
    float grabbedObjectSize;
    public float range;

    GameObject GetMouseHoverObject(float range)
    {
        Vector3 position = gameObject.transform.position;
        RaycastHit raycastHit;
        Vector3 target = position + Camera.main.transform.forward;

        if(Physics.Linecast(position, target, out raycastHit))
        {
            return raycastHit.collider.gameObject;
        }

        return null;
    }
	
    void TryGrabObject(GameObject grabObject)
    {
        if (grabObject == null || !CanGrab(grabObject))
            return;

        grabbedObject = grabObject;
        grabbedObjectSize = grabbedObject.GetComponent<Renderer>().bounds.size.magnitude;
    }

    bool CanGrab(GameObject anObject)
    {
        return anObject.GetComponent<Rigidbody>() != null;
    }

    void DropObject()
    {
        if (grabbedObject == null)
            return;

        if (grabbedObject.GetComponent<Rigidbody>() != null)
            grabbedObject.GetComponent<Rigidbody>().velocity = Vector3.zero;

        grabbedObject = null;
    }

	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButtonDown(1))
        {
            Debug.Log(grabbedObject);
            if(grabbedObject == null)
            {
                Debug.Log("try");
                TryGrabObject(GetMouseHoverObject(range));
            }
            else
            {
                Debug.Log("drop");
                DropObject();
            }
        }

        if(grabbedObject != null)
        {
            Vector3 newPosition = gameObject.transform.position + Camera.main.transform.forward * grabbedObjectSize;
            grabbedObject.transform.position = newPosition;
        }
	}
}
