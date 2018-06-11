using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class Frames : MonoBehaviour
{
    public static int SavedFrames = 0;

    private void Awake()
    {
        //SavedFrames = SaveAndLoadData.SettingSaved[0];

        QualitySettings.vSyncCount = 0;

        if (SavedFrames == 0)
        {
            Application.targetFrameRate = 30;
            SavedFrames = Application.targetFrameRate;

        }

        else Application.targetFrameRate = SavedFrames;

        Application.targetFrameRate = 30;
    }


    void SetFrame30()
    {
       SavedFrames = Application.targetFrameRate = 30;
    }

    void SetFrame60()
    {
       SavedFrames = Application.targetFrameRate = 60;
    }
}