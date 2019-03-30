using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
       
        
        if (other.CompareTag("Player"))
        {
            Player player = other.GetComponent<Player>();
            if(player == null)
            {
                Debug.Log("Other:  " + other);
                Debug.Log("Player: " + player);
            }
            player.AddCake();
            Pickup();
        }
    }

    void Pickup()
    {
        Debug.Log("Power up picked up");
        Destroy(this.gameObject);
        
    }
}
