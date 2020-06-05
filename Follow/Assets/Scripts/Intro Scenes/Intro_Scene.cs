using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Intro_Scene : MonoBehaviour
{
    public Image fader;
    public Animator anim;


    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Level One is loading...");
                        
            StartCoroutine(FadingtoLevelOne());


        }
    }

    public void ContinueButton()
    {
        Debug.Log("Level One is loading...");

        StartCoroutine(FadingtoLevelOne());

    }

    IEnumerator FadingtoLevelOne()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => fader.color.a == 1);
        SceneManager.LoadScene("Level_One");
    }
}
