using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pre_Menu_Scene2 : MonoBehaviour
{
    public Image fader;
    public Animator anim;
    
    void Start()
    {
        Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.None;

        StartCoroutine(FadingtoNextPreMenuScene());
    }

    void Update()
    {
        
    }
        

    IEnumerator FadingtoNextPreMenuScene()
    {
        yield return new WaitForSeconds(3);
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => fader.color.a == 1);
        SceneManager.LoadScene("Pre_Menu_Scene_3");
    }
}
