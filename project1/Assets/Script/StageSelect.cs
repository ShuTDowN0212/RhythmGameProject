using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour  //GameStart버튼에 연결 //확인필요 
{
    public static int[] NoteDataList = {100, 120, 130, 140, 150 };
    public static string[] StageName = { "Song1", "Level_1", "Level_2", "Level_3", "Level_4"};


    public void OnMouseDown()
    {
        SoundManager.PreviewStop();
        NoteDataLoad();
        LoadScene.LoadSceneFun();
    }



    public static void NoteDataLoad()
    {
        if(SelectSingleton.NoteNum==0)
        {
            SelectSingleton.NoteData = NoteDataList[0];
            SelectSingleton.SceneName = StageName[0];
        }
        else if (SelectSingleton.NoteNum == 1)
        {
            SelectSingleton.NoteData = NoteDataList[1];
            SelectSingleton.SceneName = StageName[1];
        }
        else if(SelectSingleton.NoteNum == 2)
        {
            SelectSingleton.NoteData = NoteDataList[2];
            SelectSingleton.SceneName = StageName[2];
        }
        else if(SelectSingleton.NoteNum == 3)
        {
            SelectSingleton.NoteData = NoteDataList[3];
            SelectSingleton.SceneName = StageName[3];
        }
        else if(SelectSingleton.NoteNum == 4)
        {
            SelectSingleton.NoteData = NoteDataList[4];
            SelectSingleton.SceneName = StageName[4];
        }

    }
}