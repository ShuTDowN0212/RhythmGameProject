using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class Resume : MonoBehaviour
{

    public static AudioSource StopSound;
    public static AudioSource ResumeSound;
    public static AudioSource ExitSound;


    public static Button PauseButton;
    public static Button ExitButton;
    public static Button ResumeButton;
    public static Button RestartButton;


    public void Awake(){


        GameObject StopButton = transform.Find("PauseButton").gameObject;
        GameObject ExitButton = transform.Find("ExitButton").gameObject;
        GameObject ResumeButton = transform.Find("UnpauseButton").gameObject;
        GameObject RestartButton = transform.Find("RestartButton").gameObject;

        StopButton.tag = "PausesButton";
        ExitButton.tag = "ExitButton";
        ResumeButton.tag = "UnpauseButton";
        RestartButton.tag = "RestartButton";


        this.InitializationData();
    }

    public void Update()
    {
        if(Input.GetMouseButtonDown(0) && gameObject.tag == "PauseButton")
        {
            OnClickPause();
        }

        if (Input.GetMouseButtonDown(0) && gameObject.tag == "UnpauseButton")
        {
            OnClickUnpause();
        }
        if (Input.GetMouseButtonDown(0) && gameObject.tag == "ExitButton")
        {
            OnClickGameExit();
        }
        if (Input.GetMouseButtonDown(0) && gameObject.tag == "RestartButton")
        {
            OnClickRestart();
        }
    }



    public static void OnClickPause()
    {
        SoundManager.Stop();
        SoundManager.PlaySound("StopSound");
        SoundManager.GamePause();
        CameraOnGame.StopCamera();
    }

    public void OnClickUnpause()
    {
        CameraOnGame.ResumeCamera();
        InvokeRepeating("ResumeSound_.Play()", 1, 3);
        Invoke("SoundManager.Resume()", 3);
        Invoke("SoundManager.GameUnpause()", 3);
    }

    public static void OnClickGameExit()
    {
        SoundManager.GameExit01();
        SoundManager.PlaySound("ExitSound");
        SceneManager.LoadScene("StageSelect");
    }

    public void OnClickRestart()
    {
        InitializationData();
        SceneManager.LoadScene("Loading");
    }



    void InitializationData()
    {
        Singletons.perfect = 0;
        Singletons.great = 0;
        Singletons.miss = 0;
        Singletons.combo = 0;
        Singletons.bestScore = 0;
        Singletons.NoteCount = 0;
        Singletons.ComboPoint = 0;
    }

}