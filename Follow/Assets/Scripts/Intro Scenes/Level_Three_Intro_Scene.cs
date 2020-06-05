using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level_Three_Intro_Scene : MonoBehaviour
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
            Debug.Log("Level Three is loading...");

            StartCoroutine(FadingtoLevelThree());

        }
    }

    public void ContinueButton()
    {
        Debug.Log("Level Three is loading...");

        StartCoroutine(FadingtoLevelThree());

    }

    IEnumerator FadingtoLevelThree()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => fader.color.a == 1);
        SceneManager.LoadScene("Level_Three");
    }
}
