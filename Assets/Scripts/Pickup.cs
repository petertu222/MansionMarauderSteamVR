using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Inventory3 inventory;
    Timer timer;

    public void Start()
    {
        timer = (Timer)FindObjectOfType(typeof(Timer));
    }

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Necklaces")
        {
            timer.playerScore += 2;
            Destroy(other.gameObject);

        }

        if (other.gameObject.tag == "Coins")
        {
            timer.playerScore += 1;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Trophy")
        {
            timer.playerScore += 3;
            Destroy(other.gameObject);
        }
    }
}