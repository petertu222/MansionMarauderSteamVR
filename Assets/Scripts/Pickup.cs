using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Inventory3 inventory;
    Timer timer;
    AudioSource audioSource;
    
    public void Start()
    {
        timer = (Timer)FindObjectOfType(typeof(Timer));
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {

    }
    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Necklaces")
        {
            audioSource.Play();
            timer.playerScore += 2;
            Destroy(other.gameObject);

        }

        if (other.gameObject.tag == "Coins")
        {
            audioSource.Play();
            timer.playerScore += 1;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Trophy")
        {
            audioSource.Play();
            timer.playerScore += 3;
            Destroy(other.gameObject);
        }
    }
}