using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main_Menu : MonoBehaviour
{
    public Image fader;
    public Animator anim;

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
   
    public void PlayGame()
    {
        Debug.Log("Game loading...");
        StartCoroutine (FadingtoPlayGame());        
    }

    IEnumerator FadingtoPlayGame()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => fader.color.a == 1);
        SceneManager.LoadScene("Intro_Scene");
    }

    public void ControlsButton()
    {
        Debug.Log("Controls menu loading...");
        StartCoroutine(FadingtoControlsMenu());        
    }

    IEnumerator FadingtoControlsMenu()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => fader.color.a == 1);
        SceneManager.LoadScene("Controls_Menu");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        StartCoroutine(FadingtoQuit());
    }

    IEnumerator FadingtoQuit()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => fader.color.a == 1);
        Application.Quit();
    }



}
