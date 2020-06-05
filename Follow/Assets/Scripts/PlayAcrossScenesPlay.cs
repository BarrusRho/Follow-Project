using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAcrossScenesPlay : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        PlayAcrossScenes1.Instance.gameObject.GetComponent<AudioSource>().Play();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
