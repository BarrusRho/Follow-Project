using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    public bool isMusicOn = true;    

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            UIManager uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();

            Player player = other.GetComponent<Player>();

            if (uiManager != null)
            {
                uiManager.ShowPrompt();
            }
        }

            if (Input.GetKeyDown(KeyCode.F) && isMusicOn == false)
            {
            Player player = other.GetComponent<Player>();
                if (player != null)
                {
                    isMusicOn = true;                    

                    AudioSource audio = GetComponent<AudioSource>();

                    audio.Play();                        
                }
            }
            
            if (Input.GetKeyDown(KeyCode.F) && isMusicOn == true)
        {
                Player player = other.GetComponent<Player>();
                if (player != null)
                {
                    isMusicOn = false;                    

                    AudioSource audio = GetComponent<AudioSource>();

                    audio.Stop();                    
                }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            UIManager uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
            if (uiManager != null)
            {
                uiManager.HidePrompt();               
            }

        }
    }

}
