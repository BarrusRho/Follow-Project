using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAcrossScenesStop1 : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        PlayAcrossScenes1.Instance.gameObject.GetComponent<AudioSource>().Stop();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
