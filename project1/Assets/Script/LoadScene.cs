using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour { //씬들 로드하는 스크립트 이지만 Async 때문에 일부분만 사용

    public static string NextSceneName;

    public static AudioSource SelectSound00;
    public static AudioSource ReturnSound00;

	// Use this for initialization

	public void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			}



    public static void SelectNext()
    {
        SoundManager.PlaySound("SelectSound00");
        
        SceneManager.LoadScene("Loading", LoadSceneMode.Additive);
    }


    public static void ResturnSelect()
    {
        SoundManager.PlaySound("ReturnSound");
        SceneManager.LoadScene("StageSelect");
    }

    public static void GameEndFun()
    {
        SceneManager.LoadScene("ScoreBoard");
    }

    public static void LoadSceneFun()
    {
        SceneManager.LoadScene("Loading");
    }
}
