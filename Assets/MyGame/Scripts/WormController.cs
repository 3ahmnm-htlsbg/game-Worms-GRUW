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

    [Header("Input")]
    public KeyCode shootKey;
    public KeyCode jumpKey;
    public KeyCode leftKey;
    public KeyCode rightKey;
    public KeyCode rotUpKey;
    public KeyCode rotDownKey;

    void Update()
    {
        if (Input.GetKeyDown(jumpKey))
        {
            rb.AddForce(jump);
        }
        if (Input.GetKey(rightKey))
        {
            rb.AddForce(move);
        }
        if (Input.GetKey(leftKey))
        {
            rb.AddForce(-move);
        }
        if (Input.GetKeyDown(shootKey))
        {
            GameObject ball = Instantiate(projectile, spawnPosition.position, Quaternion.identity);
            ball.GetComponent<Rigidbody>().AddForce(bazooka.transform.up * shoot);
        }

        if (Input.GetKey(rotUpKey))
        {
            bazooka.transform.Rotate(0,0,-5, Space.Self);
            Debug.Log("Button Input detected");
        }

        if (Input.GetKey(rotDownKey))
        {
            bazooka.transform.Rotate(0, 0, 5, Space.Self);
            Debug.Log("Button Input detected");
        }

    }
}
