using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayOnAwake : MonoBehaviour
{
    [SerializeField]
    private GameObject _audioLocation;

    [SerializeField]
    private AudioClip _audio;

	// Use this for initialization
	void Start ()
    {
        AudioSource.PlayClipAtPoint(_audio, _audioLocation.transform.position, 0.05f);	
	}
	
	
}
