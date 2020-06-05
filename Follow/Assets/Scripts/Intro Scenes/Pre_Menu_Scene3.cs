using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pre_Menu_Scene3 : MonoBehaviour
{
    public Image fader;
    public Animator anim;
    
    void Start()
    {
        Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.None;

        StartCoroutine(FadingtoInitialMainMenu());
    }

    void Update()
    {
        
    }
        

    IEnumerator FadingtoInitialMainMenu()
    {
        yield return new WaitForSeconds(3);
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => fader.color.a == 1);
        SceneManager.LoadScene("Main_Menu");
    }
}
