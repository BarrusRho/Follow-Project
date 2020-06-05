using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAcrossScenes1 : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		
	}
	
    private static PlayAcrossScenes1 instance = null;

    public static PlayAcrossScenes1 Instance
    {
        get { return instance; }
    }
        
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
