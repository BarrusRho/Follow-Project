using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryTextTrigger5 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            UIManager uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
            
            if (uiManager != null)
            {
                uiManager.StoryText5();
            }

            Destroy(this.gameObject, 8f);
        }
    }

}
