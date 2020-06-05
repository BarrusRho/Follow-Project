using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Credits_Scene : MonoBehaviour
{
    public Image fader;
    public Animator anim;

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void BackButton()
    {
        Debug.Log("Main Menu is loading...");
        StartCoroutine(FadingtoMainMenu());
    }

    public void Quit()
    {
        StartCoroutine(FadingtoQuit());
    }

    IEnumerator FadingtoMainMenu()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => fader.color.a == 1);
        SceneManager.LoadScene("Main_Menu_2");
    }

    IEnumerator FadingtoQuit()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => fader.color.a == 1);
        Application.Quit();
    }

}
