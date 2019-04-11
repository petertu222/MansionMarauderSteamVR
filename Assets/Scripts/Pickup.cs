using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Inventory3 inventory;
    public GameObject itemButton;
    Timer timer;

    public void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory3>();
        timer = (Timer)FindObjectOfType(typeof(Timer));
    }

    // void OnCollisionEnter(Collider other)
    // {
    //     if (other.gameObject.tag == "Hands" || other.gameObject.tag == "Player")
    //     {

    //         if (gameObject.tag == "Necklaces")
    //         {
    //             timer.playerScore += 2;
    //             Destroy(gameObject);
    //         }

    //         if (gameObject.tag == "Coins")
    //         {
    //             timer.playerScore += 1;
    //             Destroy(gameObject);
    //         }
    //         if (gameObject.tag == "Trophy")
    //         {
    //             timer.playerScore += 3;
    //             Destroy(gameObject);
    //         }

    //     }
    // }

    void OnTriggerEnter(Collider other)
    {
        if (/*other.gameObject.tag == "Hands" || */other.gameObject.tag == "Player")
        {

            if (gameObject.tag == "Necklaces")
            {
                timer.playerScore += 2;
                
            }

            if (gameObject.tag == "Coins")
            {
                timer.playerScore += 1;
            }

            if (gameObject.tag == "Trophy")
            {
                timer.playerScore += 3;
            }

            for (int i = 0; i < inventory.slots.Length; i++) 
            {
                if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
                }
        }
    }
}