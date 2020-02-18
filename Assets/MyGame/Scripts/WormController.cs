using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject projectile;
    public Transform spawnPosition;
    public GameObject bazooka;
    public Vector3 jump;
    public Vector3 move;
    public float shoot = 100;

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
            ball.GetComponent<Rigidbody>().AddForce(bazooka.transform.up * shoot);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            bazooka.transform.Rotate(0,0,-15, Space.Self);
            Debug.Log("Button Input detected");
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            bazooka.transform.Rotate(0, 0, 15, Space.Self);
            Debug.Log("Button Input detected");
        }

    }
}
