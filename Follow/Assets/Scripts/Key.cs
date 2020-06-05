using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField]
    private AudioClip _keyPickup;

    private void OnTriggerStay (Collider other)
    {
        if (other.tag == "Player")
        {
            UIManager uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();

            if (uiManager != null)
            {
                uiManager.ShowPrompt ();
            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                Player player = other.GetComponent<Player>();
                if (player != null)
                {
                    player.hasKey = true;
                    AudioSource.PlayClipAtPoint(_keyPickup, Camera.main.transform.position, 1f);

                    //UIManager uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();

                    if (uiManager != null)
                    {
                        uiManager.CollectedKey();
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
