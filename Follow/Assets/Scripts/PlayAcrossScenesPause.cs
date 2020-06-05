using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAcrossScenesPause : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        PlayAcrossScenes1.Instance.gameObject.GetComponent<AudioSource>().Pause();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
