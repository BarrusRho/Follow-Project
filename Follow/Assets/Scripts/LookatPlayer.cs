using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookatPlayer : MonoBehaviour
{
    public Transform target;

	// Use this for initialization
	void Start ()
    {
		if(target != null)
        {
            transform.LookAt(target);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
