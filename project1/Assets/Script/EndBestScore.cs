using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndBestScore : MonoBehaviour
{
    public static float BestPoint;

    public Texture NewRecord;
    public Texture NRecord;

    public Text BestAccuracy; //최고 Acc
    public Text BestCombo; //최고 Combo

    public void Awake()
    {
        BestPoint = (Singletons.AccP + Singletons.AllAccuracy);

        if (SaveAndLoadData.Point < BestPoint)
        {
            NewRecord = null;
            BestPoint = SaveAndLoadData.HighScoreSaved[SelectSingleton.StageNum];
        }
        else
        {
            NewRecord = NRecord;
            SaveAndLoadData.HighScore[SelectSingleton.StageNum] = Singletons.bestScore.ToString();
        }

        SaveAndLoadData.SaveData();

        ScoreViewBest();
    }

    public void ScoreViewBest()
    {
        BestAccuracy.text = SaveAndLoadData.Point.ToString();
        BestCombo.text = Singletons.bestScore.ToString();
    }
}