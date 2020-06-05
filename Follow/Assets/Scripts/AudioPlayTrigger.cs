using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject _audiosource;

    [SerializeField]
    private AudioClip _audio;

    [SerializeField]
    private Collider _collider;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _collider.enabled = false;
            
            AudioSource.PlayClipAtPoint(_audio, _audiosource.transform.position);                       
        }
    }

}
