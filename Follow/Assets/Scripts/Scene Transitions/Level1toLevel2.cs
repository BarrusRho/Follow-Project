using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level1toLevel2 : MonoBehaviour
{
    public Image fader;
    public Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("The next level is loading...");

            StartCoroutine(FadingtoLevelTwoIntroScene());

        }
    }

    IEnumerator FadingtoLevelTwoIntroScene()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => fader.color.a == 1);
        SceneManager.LoadScene("Level_Two_Intro_Scene");
    }

}
