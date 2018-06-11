using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Option : MonoBehaviour
{
    public static int UserSpeed = 3;

    public void Awake()
    {
        if (!(SaveAndLoadData.SettingSaved[1] == 3))
        {
            UserSpeed = SaveAndLoadData.SettingSaved[1];
        }
        DontDestroyOnLoad(this);
    }

    public void OnClickDownSpeed()
    {
        UserSpeed =- 1;
        SaveAndLoadData.SaveSetting();
    }
    public void OnClickUpSpeed()
    {
        UserSpeed =+ 1;
        SaveAndLoadData.SaveSetting();
    }


    public void OnClickResetSpeed()
    {
        UserSpeed = 3;
    }

}