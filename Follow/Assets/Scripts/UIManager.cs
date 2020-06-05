using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Image fader;

    public Animator anim;

    [SerializeField]
    private GameObject _key;

    [SerializeField]
    private GameObject _letters;

    [SerializeField]
    private Text _interactPrompt;

    [SerializeField]
    private Text _lockedDoorPrompt;

    [SerializeField]
    private Text _lettersInteractPrompt;

    [SerializeField]
    private Text _storyText;

    [SerializeField]
    private Text _storyText2;

    [SerializeField]
    private Text _storyText3;

    [SerializeField]
    private Text _storyText4;

    [SerializeField]
    private Text _storyText5;

    [SerializeField]
    private Text _storyText6;

    [SerializeField]
    private GameObject _pauseMenuPanel;

    [SerializeField]
    private GameObject _controlsMenuPanel;

    void Update()
    {
        Pause();
    }

    public void CollectedKey ()
    {
        _key.SetActive(true);
    }

    public void RemoveKey ()
    {
        _key.SetActive(false);
    }

    public void CollectedLetters ()
    {
        _letters.SetActive(true);
    }
	
    public void RemoveLetters ()
    {
        _letters.SetActive(false);
    }

    public void ShowPrompt ()
    {
        _interactPrompt.enabled = true;
    }

    public void HidePrompt ()
    {
        _interactPrompt.enabled = false;
    }

    public void ShowLettersPrompt ()
    {
        _lettersInteractPrompt.enabled = true;
    }

    public void HideLettersPrompt ()
    {
        _lettersInteractPrompt.enabled = false;
    }

    public void LockedDoorPrompt ()
    {
        _lockedDoorPrompt.enabled = true;
    }

    public void HideLockedDoorPrompt()
    {
        _lockedDoorPrompt.enabled = false;
    }

    public void StoryText()
    {
        _storyText.enabled = true;
    }

    public void StoryText2()
    {
        _storyText2.enabled = true;
    }

    public void StoryText3()
    {
        _storyText3.enabled = true;
    }

    public void StoryText4()
    {
        _storyText4.enabled = true;
    }

    public void StoryText5()
    {
        _storyText5.enabled = true;
    }

    public void StoryText6()
    {
        _storyText6.enabled = true;
    }

    public void Pause ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _pauseMenuPanel.SetActive(true);

            GameObject.Find("Player").GetComponent<LookX>().enabled = false;
            GameObject.Find("LookY").GetComponent<LookY>().enabled = false;

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            Time.timeScale = 0f;
        }
    }
     

    public void ResumePlay ()
    {
        _pauseMenuPanel.SetActive(false);
        _controlsMenuPanel.SetActive(false);

        GameObject.Find("Player").GetComponent<LookX>().enabled = true;
        GameObject.Find("LookY").GetComponent<LookY>().enabled = true;


        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        Time.timeScale = 1f;
    }

    public void ShowControlsMenuPanel ()
    {
        _controlsMenuPanel.SetActive(true);
    }

    public void HideControlsMenuPanel ()
    {
        _controlsMenuPanel.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }


    
}
