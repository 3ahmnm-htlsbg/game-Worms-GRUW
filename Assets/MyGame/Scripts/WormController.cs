using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 jump;
    public Vector3 move;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(jump);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(move);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-move);
        }
    }
}
