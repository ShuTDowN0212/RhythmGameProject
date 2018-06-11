using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainScene : MonoBehaviour
{
    public Texture[] GameStart;

    public void Start()
    {
        SoundManager.MainMusic_01.volume = 1.0f;
        SoundManager.GameMenuOn();
    }

    public void Update()
    {
        ExitBack();

        if(Input.GetMouseButtonDown(0))
        {
            InvokeRepeating("StartVolume()", 0.2f, 2);
            OnClickStartButton();
        }
    }

    public void OnClickStartButton()
    {
        SceneManager.LoadScene("Loading");
        SoundManager.StartSound.Play();
        SoundManager.GameMenuOff();
    }

    public void ExitBack()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
        if(Application.platform == RuntimePlatform.IPhonePlayer)
        {
            if(Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }

    void StartVolume()
    {
        SoundManager.MainMusic_01.volume =- 0.05f;

    }
}