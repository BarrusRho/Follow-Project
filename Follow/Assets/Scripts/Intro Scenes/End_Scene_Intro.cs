using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class End_Scene_Intro : MonoBehaviour
{
    public Image fader;
    public Animator anim;

	// Use this for initialization
	void Start ()
    {
        Cursor.visible = false;

        StartCoroutine(FadingtoEndScene());
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    IEnumerator FadingtoEndScene()
    {
        yield return new WaitForSeconds(23);
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => fader.color.a == 1);
        SceneManager.LoadScene("End_Scene");
    }
}
