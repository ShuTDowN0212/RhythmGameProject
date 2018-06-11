using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Singletons : MonoBehaviour  //인 게임 싱글톤
{
    public static int perfect = 0;
    public static int great = 0;
    public static int miss = 0;

    public static int PerfectP = 0;
    public static int GreatP = 0;
    public static int MissP = 0;

    public static int combo = 0; //현재 콤보
    public static int PCombo = 0;

    public static float ComboPoint = 0; //계산전 정확도

    public static int NoteCount = 0; // 계산시 필요한 노트카운트

    public static int bestScore = 0; //베스트 스코어

    public static float musicVolume = 1f;


    public static float AllAccuracy = 0.00f; //일반 정확도

    public static float AccP= 0.00f; //감압 정확도


    private int currentCombo;
    public Text ComboText;
    public Text ComboTextP;

    public Text AccText;
    public Text BestScore;

    private void Awake()
    {

        ComboText.text = "Combo : " + combo.ToString();
        ComboTextP.text = "PCombo : " + PCombo.ToString();
        BestScore.text = "HighScore : " + bestScore.ToString();
        AccText.text = "Accuracy : " + (0.00f).ToString();
    }

    public void Update(){

        ComboText.text = "Combo : " + combo.ToString();
        ComboTextP.text = "PCombo : " + PCombo.ToString();

        if (combo > bestScore)
        {
            bestScore = combo;
            BestScore.text = "HighScore : " + bestScore.ToString();
        }

        AccText.text = "Accuracy : " + ((AllAccuracy + AccP)).ToString();
    }
   
}
