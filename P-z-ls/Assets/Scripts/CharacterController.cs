using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

    public float speed;
    private Rigidbody rigid;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxisRaw("Vertical");
        Vector3 move = new Vector3(moveH, 0, moveV);
        rigid.AddForce(move * speed);
    }
}
