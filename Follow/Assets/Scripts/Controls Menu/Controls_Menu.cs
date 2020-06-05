using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controls_Menu : MonoBehaviour
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

    IEnumerator FadingtoMainMenu()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => fader.color.a == 1);
        SceneManager.LoadScene("Main_Menu");
    }

}
