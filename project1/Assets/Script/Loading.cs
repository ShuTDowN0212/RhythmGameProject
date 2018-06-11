using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour {   //PlayingScene 로딩하는 스크립트 //로딩바 사용 //강제로 5초이상 로딩에 사용되게 해둠

    public Slider LoadSlider;
    public bool IsDone = false;
    public float LoadTime = 0f;

    AsyncOperation asyncoperation;


    // Use this for initialization
    void Start () {
        StartCoroutine(GameLoad("PlayScene"));
        
	}
	
	// Update is called once per frame
	void Update () {
        LoadTime += Time.deltaTime;
        LoadSlider.value = LoadTime;
        if (LoadTime >= 5)
        {
            asyncoperation.allowSceneActivation = true;
        }
	}


    public IEnumerator GameLoad(string SceneName)
    {
        asyncoperation = SceneManager.LoadSceneAsync(SceneName);
        asyncoperation.allowSceneActivation = false;

        if(IsDone == false)
        {
            IsDone = true;
            while (asyncoperation.progress < 0.9f)
            {
                LoadSlider.value = asyncoperation.progress;

                yield return true;
            }
        }
    }
}
