﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WormController : MonoBehaviour
{
    [Header("Healthsystem")]
    public int health = 10;

    [Header("Fill Out")]
    public Rigidbody rb;
    public GameObject projectile;
    public Transform spawnPosition;
    public GameObject bazooka;
    public Text healthText;
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
        HandleInput();

        healthText.text = health.ToString();

        if (health == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            health = health - 1;
        }
    }

    public void HandleInput()
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
            bazooka.transform.Rotate(0, 0, -5, Space.Self);
            Debug.Log("Button Input detected");
        }
        if (Input.GetKey(rotDownKey))
        {
            bazooka.transform.Rotate(0, 0, 5, Space.Self);
            Debug.Log("Button Input detected");
        }
    }
}
