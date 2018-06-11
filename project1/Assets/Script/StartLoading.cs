using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartLoading : MonoBehaviour { //게임 킬때 메인화면 스타트화면 가기전 로딩

    [SerializeField]
    Image LoadingBar;

	// Use this for initialization
	void Start () {
        StartCoroutine(LoadStart());
	}

    IEnumerator LoadStart()
    {
        yield return null;

        AsyncOperation MainOper = SceneManager.LoadSceneAsync("Main");
        AsyncOperation StageOper = SceneManager.LoadSceneAsync("StageSelect");

        MainOper.allowSceneActivation = false;
        StageOper.allowSceneActivation = false;

        float Timer = 0.0f;

        while (!MainOper.isDone && !StageOper.isDone)
        {
            yield return null;

            Timer += Time.deltaTime;

            if((MainOper.progress + StageOper.progress) >= 1.8f)
            {
                LoadingBar.fillAmount = Mathf.Lerp(LoadingBar.fillAmount, 1f, Timer);
                //Slide는 LoadingBar.value지만 이미지가 찌그러짐
                if (LoadingBar.fillAmount == 1.0f)
                {
                    MainOper.allowSceneActivation = true;
                    StageOper.allowSceneActivation = true;
                }
            }
            else
            {
                LoadingBar.fillAmount = Mathf.Lerp(LoadingBar.fillAmount, MainOper.progress + StageOper.progress, Timer);
                if(LoadingBar.fillAmount >= (MainOper.progress + StageOper.progress))
                {
                    Timer = 0f;
                }
            }
        }

       
    }

}
