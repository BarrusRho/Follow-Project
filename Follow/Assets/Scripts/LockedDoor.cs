using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : MonoBehaviour
{       
    private Animator _animator = null;

    public bool isDoorOpen = false;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            UIManager uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();

            Player player = other.GetComponent<Player>();

            if (player.hasKey == true)
            {
                if (uiManager != null)
                {                    
                    uiManager.ShowPrompt();
                }
            }

            if (player.hasKey == false)
            {
                if (uiManager != null)
                {
                    uiManager.LockedDoorPrompt();
                }
            }                   

            if (Input.GetKeyDown(KeyCode.F))
            {
                //Player player = other.GetComponent<Player>();
                if (player != null)
                {
                    if (player.hasKey == true)
                    {
                        player.hasKey = false;

                        //UIManager uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
                        if (uiManager != null)
                        {
                            uiManager.RemoveKey();
                            uiManager.HidePrompt();
                        }

                        AudioSource audio = GetComponent<AudioSource>();
                        audio.Play();

                        _animator.SetBool("doesPlayerHaveKey", true);

                        isDoorOpen = true;
                                            
                        //DoorOpen ();
                        //play animation of door opening

                    }                  
                }
            }

            if (isDoorOpen == true)
            {
                if(uiManager != null)
                {
                    uiManager.HideLockedDoorPrompt();
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
                uiManager.HideLockedDoorPrompt();
            }

        }
    }


}
