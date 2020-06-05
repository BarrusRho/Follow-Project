using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject _textToDisplay;

    public bool textIsOff = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && textIsOff)
        {
            textIsOff = false;

            _textToDisplay.SetActive(true);
            
        }
    }

}
