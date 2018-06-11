using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOnSelect : MonoBehaviour {

    public static GameObject MainCamera = GameObject.Find("MainCamera");

    public static float CameraZ = 10;

    public void Awake()
    {
        MainCamera.transform.position =  new Vector3(-250, -250, 0);
    }


    public static void StageCameraPlus()
    {
        Vector3 Target = new Vector3(MainCamera.transform.position.x + 50, MainCamera.transform.position.y + 50, CameraZ);
        switch (SelectSingleton.StageNum)
        {
            case 9:
                Vector3 Return = new Vector3(-250, -250, CameraZ);
                MainCamera.transform.position = Vector3.LerpUnclamped(MainCamera.transform.position, Return, Time.deltaTime * 4f);

                break;

            default:
                MainCamera.transform.position = Vector3.Lerp(MainCamera.transform.position, Target, Time.deltaTime * 2f);

                break;

        }
    }

    public static void StageCameraMinus()
    {
        Vector3 Target = new Vector3(MainCamera.transform.position.x - 50, MainCamera.transform.position.y - 50, CameraZ);
        switch (SelectSingleton.StageNum)
        {
            case 0:
                Vector3 Return = new Vector3(250, 250, CameraZ);
                MainCamera.transform.position = Vector3.LerpUnclamped(MainCamera.transform.position, Return, Time.deltaTime * 4f);

                break;

            default:
                MainCamera.transform.position = Vector3.Lerp(MainCamera.transform.position, Target, Time.deltaTime * 2f);

                break;

        }
    }

    public static void CameraMoving()
    {
        Vector3 Target = new Vector3(SwipeLogic.Moving.x - SwipeLogic.Start2D.x, SwipeLogic.Moving.y - SwipeLogic.Start2D.y, CameraZ);
        MainCamera.transform.position = Vector3.Lerp(MainCamera.transform.position, Target, Time.deltaTime * 2f);
    }
}
