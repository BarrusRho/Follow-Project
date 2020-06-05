using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryTextTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            UIManager uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
            
            if (uiManager != null)
            {
                uiManager.StoryText();
            }

            Destroy(this.gameObject, 8f);
        }
    }

}
