using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public int healthBonus = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            WormController worm = collision.gameObject.GetComponent<WormController>();
            worm.health = worm.health + healthBonus;

            Destroy(this.gameObject);
        }
    }
}
