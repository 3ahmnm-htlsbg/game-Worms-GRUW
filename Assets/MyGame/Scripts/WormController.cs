using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject projectile;
    public Transform spawnPosition;
    public Vector3 jump;
    public Vector3 move;
    public Vector3 shoot;

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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject ball = Instantiate(projectile, spawnPosition.position, Quaternion.identity);
            ball.GetComponent<Rigidbody>().AddForce(shoot);
        }

    }
}
