using System;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed;
    public Rigidbody _rigidbody;

    private void Update() {
        _rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, 0, Input.GetAxis("Vertical") * speed);
    }
}