using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resolution : MonoBehaviour {   //해상도랑 화면고정  //캔버스에 연결

	//Before initializztion
	void Awake ()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Screen.SetResolution(Screen.width, Screen.height, true);

        if (SelectSingleton.SceneName == "PlayScene")
        {
            ScreenPin();
        }
    }



    public static void ScreenPin()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        Screen.orientation = ScreenOrientation.Landscape;

        Screen.orientation = ScreenOrientation.AutoRotation;
        Screen.autorotateToPortrait = false;
        Screen.autorotateToPortraitUpsideDown = false;
        Screen.autorotateToLandscapeLeft = true;
        Screen.autorotateToLandscapeRight = true;
    }
}
