using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuTrigger : MonoBehaviour
{
    [SerializeField] GameObject winText;
    [SerializeField] Text winScore;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "StartGame")
        {
            SceneManager.LoadScene("TestRoom");
        }
        else if(other.tag == "QuitGame")
        {
            Application.Quit();
        }
    }

    void Update()
    {
        if (Scores.endGame == true)
        {
            winScore.text = "$" + Scores.currentScore;
            winText.SetActive(true);
        
            Scores.endGame = false;
            //activate UI, insert score into UI
        }
    }
}