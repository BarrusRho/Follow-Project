﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letters : MonoBehaviour
{
    [SerializeField]
    private AudioClip _lettersPickup;

    private void OnTriggerStay (Collider other)
    {
        if (other.tag == "Player")
        {
            UIManager uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();

            if (uiManager != null)
            {
                uiManager.ShowPrompt();
            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                Player player = other.GetComponent<Player>();
                if (player != null)
                {
                    player.hasLetters = true;
                    AudioSource.PlayClipAtPoint(_lettersPickup, Camera.main.transform.position, 1f);

                    //UIManager uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();

                    if (uiManager != null)
                    {
                        uiManager.CollectedLetters();
                        uiManager.HidePrompt();
                    }

                    Destroy(this.gameObject);
                }
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
