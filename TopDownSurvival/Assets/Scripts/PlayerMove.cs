using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {


    private Vector3 movement;
    private Rigidbody rb;

	void Start () {
      rb = GetComponent<Rigidbody>();
      movement = Vector3.zero;
    }

    private void FixedUpdate()
    {
        PerformMovement();
    }

    void PerformMovement()
    {
        if (movement != null)
        {
            rb.transform.Translate(movement);
        }
    }

    public void setMovement(Vector3 _movement)
    {
        movement = _movement;
    }
}
