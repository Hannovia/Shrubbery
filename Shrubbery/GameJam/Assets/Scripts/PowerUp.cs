using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player1"))
        {
            Player player = other.GetComponent<Player>();
            player.AddCake1();
            Pickup();
        }

        if (other.CompareTag("Player2"))
        {
            Player player = other.GetComponent<Player>();
            player.AddCake2();
            Pickup();
        }

        if (other.CompareTag("Player3"))
        {
            Player player = other.GetComponent<Player>();
            player.AddCake3();
            Pickup();
        }

        if (other.CompareTag("Player4"))
        {
            Player player = other.GetComponent<Player>();
            player.AddCake4();
            Pickup();
        }

    }

    void Pickup()
    {
        Debug.Log("Power up picked up");
        Destroy(this.gameObject);

    }
}
