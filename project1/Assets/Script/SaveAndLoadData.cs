using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveAndLoadData : MonoBehaviour
{
    public static List<float> HighScoreSaved = new List<float>();
    public static List<int> SettingSaved = new List<int>();
    public static float Point = 32.00f;
    public static int FrameSet;

    public static string[] HighScore;
    public static string[] Setting;

    public int DefaultFrame = 30;
    public int DefaultSpeed = 3;
    public float DefaultScore = 0f;


    public void Awake()
    {
        DontDestroyOnLoad(this);

        MakeScore();

        MakeSetting();

        LoadData();
    }


    public void MakeScore()
    {
        HighScore = new string[19];

        HighScore[0] = "Score1";
        HighScore[1] = "Score2";
        HighScore[2] = "Score3";
        HighScore[3] = "Score4";
        HighScore[4] = "Score5";
        HighScore[5] = "Score6";
        HighScore[6] = "Score7";
        HighScore[7] = "Score8";
        HighScore[8] = "Score9";
        HighScore[9] = "Score10";
        HighScore[10] = "Score0#";
        HighScore[11] = "Score1#";
        HighScore[12] = "Score2#";
        HighScore[13] = "Score3#";
        HighScore[14] = "Score4#";
        HighScore[15] = "Score5#";
        HighScore[16] = "Score6#";
        HighScore[17] = "Score7#";
        HighScore[18] = "Score8#";
        HighScore[19] = "Score9#";

        object[] values = new object[HighScore.Length];
        values[0] = DefaultScore;
        values[1] = DefaultScore;
        values[2] = DefaultScore;
        values[3] = DefaultScore;
        values[4] = DefaultScore;
        values[5] = DefaultScore;
        values[6] = DefaultScore;
        values[7] = DefaultScore;
        values[8] = DefaultScore;
        values[9] = DefaultScore;
        values[10] = DefaultScore;
        values[11] = DefaultScore;
        values[12] = DefaultScore;
        values[13] = DefaultScore;
        values[14] = DefaultScore;
        values[15] = DefaultScore;
        values[16] = DefaultScore;
        values[17] = DefaultScore;
        values[18] = DefaultScore;
        values[19] = DefaultScore;

        for (int i = 0; i < HighScore.Length; i++)
        {
            if (!ExistsData(HighScore[i], (Value_Type)i))
            {
                SetData(HighScore[i], values[i], (Value_Type)i);
            }
        }
    }

    public void MakeSetting()
    {
        Setting = new string[2];
        Setting[0] = "30";
        Setting[1] = "3";

        object[] Settingvalue = new object[Setting.Length];
        Settingvalue[0] = DefaultFrame;
        Settingvalue[1] = DefaultSpeed;

        for (int i = 0; i < Settingvalue.Length; i++)
        {
            // PlayerPrefs에 데이터가 존재하는지 검사 후 없다면
            // Key 생성하면서 Default 값을 세팅한다.
            if (!ExistsData(Setting[i], (Value_Type)i))
                SetData(Setting[i], Settingvalue[i], (Value_Type)i);
        }
    }

    public static void LoadData()
    {
        for (int i = 0; i < HighScore.Length; i++)
        {
            HighScoreSaved.Add(PlayerPrefs.GetFloat(HighScore[i]));
        }
        SettingSaved[0] = PlayerPrefs.GetInt(Setting[0]);
        SettingSaved[1] = PlayerPrefs.GetInt(Setting[1]);
    }


    public static void SaveData()
    {
        PlayerPrefs.SetFloat(HighScoreSaved[SelectSingleton.StageNum].ToString(), EndBestScore.BestPoint);
    }

    public static void SaveSetting()
    {
        PlayerPrefs.SetInt(Setting[0], Frames.SavedFrames);
        PlayerPrefs.SetInt(Setting[1], Option.UserSpeed);
    }





    public enum Value_Type
    {
        TYPE_STRING,
        TYPE_INT,
        TYPE_FLOAT
    }

    void SetData(string key, object value, Value_Type type)
    {
        switch (type)
        {
            case Value_Type.TYPE_STRING:
                PlayerPrefs.SetString(key, (string)value);
                break;
            case Value_Type.TYPE_INT:
                PlayerPrefs.SetInt(key, (int)value);
                break;
            case Value_Type.TYPE_FLOAT:
                PlayerPrefs.SetFloat(key, (float)value);
                break;
        }
    }

    bool ExistsData(string key, Value_Type type)
    {
        bool exists = false;
        // Get 함수의 두 번째 인자는 Default로 각각의 타입마다 정해져 있다.
        // 만약 해당 Key 값을 찾을 수 없을 때는 두 번째 인자 값을 반환한다.
        // 이때 두 번째 인자를 넘겨주지 않으면 각 Get 함수의 Default 값이 반환하지만,
        // 사용자가 두 번째 인자값을 넘기면 해당 Key가 존재하지 않을 때 같이 넘긴
        // 두 번째 인자값을 반환한다.
        // string의 Default는 ""
        // int의 Default는 0
        // float의 Default는 0.0f
        switch (type)
        {
            case Value_Type.TYPE_STRING:
                exists = (PlayerPrefs.GetString(key) != "") ? true : false;
                break;
            case Value_Type.TYPE_INT:
                exists = (PlayerPrefs.GetInt(key) != 0) ? true : false;
                break;
            case Value_Type.TYPE_FLOAT:
                exists = (PlayerPrefs.GetFloat(key) != 0f) ? true : false;
                break;
        }
        return exists;
    }



}
