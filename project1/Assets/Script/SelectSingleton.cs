using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectSingleton : MonoBehaviour
{
    public static int NoteNum;
    public static int StageNum;
    public static int NoteData;

    public static string SceneName;

    public void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        NoteNum = 0;
        StageNum = 0;
    }

    Text HighScoreText;




    private void Update()
    {

        string HighScoreString = SaveAndLoadData.HighScoreSaved[StageNum].ToString();
        HighScoreText.text = HighScoreString;
        BackToMain();
    }

    public void BackToMain()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene("Main");
            }
        }
        if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene("Main");
            }
        }
    }
}