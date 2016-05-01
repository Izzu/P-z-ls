using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

    public float speed = 6f;
    public float rotateSpeed = 0.0005f;
    Vector3 movement;
    Vector3 rotation;
    Rigidbody playerRigidbody;

    // Use this for initialization
    void Awake () {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float rotate = Input.GetAxis("Horizontal");
        float move = Input.GetAxisRaw("Vertical");
        Move(move);
        Turning(rotate);
    }

    void Move(float move)
    {
        movement.Set(0f, 0f, move);
        movement = movement.normalized * speed * Time.deltaTime;
        movement = transform.TransformDirection(movement);
        playerRigidbody.MovePosition(playerRigidbody.position + movement);
    }

    void Turning(float rotate)
    {
        rotation.Set(0f, rotate, 0f);
        rotation = rotation.normalized * rotateSpeed;
        Quaternion rotated = Quaternion.Euler(rotation);
        playerRigidbody.MoveRotation(playerRigidbody.rotation * rotated);

    }
}
