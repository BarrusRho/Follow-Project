using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level5toEnd : MonoBehaviour
{
    public Image fader;
    public Animator anim;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            UIManager uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();

            Player player = other.GetComponent<Player>();

            if (player.hasLetters == true)
            {
                if(uiManager != null)
                {
                    uiManager.ShowLettersPrompt();
                }
            }

            if (player.hasLetters == false)
            {
                if (uiManager != null)
                {
                    uiManager.HideLettersPrompt();
                }
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                if (player.hasLetters == true)
                {
                    player.hasLetters = false;

                    if (uiManager != null)
                    {
                        uiManager.RemoveLetters();
                        uiManager.HideLettersPrompt();
                    }

                    StartCoroutine(FadingtoEndSceneIntro());
                }
            }

        }
    }

    IEnumerator FadingtoEndSceneIntro()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => fader.color.a == 1);
        SceneManager.LoadScene("End_Scene_Intro");
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            UIManager uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();

            if (uiManager != null)
            {
                uiManager.HideLettersPrompt();
            }
        }
    }
}
