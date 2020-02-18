using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            var player = collision.gameObject;
            var wormCon = player.GetComponent<WormController>();
            wormCon.shoot = 1000f;
            Destroy(this.gameObject);
        }
    }
}
