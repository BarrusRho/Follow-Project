using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlay : MonoBehaviour
{    
    private AudioSource _audioSource;

    [SerializeField]
    private Collider _collider;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _audioSource.Play();

            _collider.enabled = false;
        }
    }

    // Use this for initialization
    void Start ()
    {
        _audioSource = GetComponent<AudioSource>();
	}
	
}
