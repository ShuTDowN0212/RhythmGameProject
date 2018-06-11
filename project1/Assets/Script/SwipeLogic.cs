using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeLogic : MonoBehaviour {
    private bool NowSwipe;
    public static Vector2 Start2D;
    private Vector2 End2D;
    public static Vector2 Moving;

    public AudioSource SwipeSound;

   void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Vector3 StartPos = Camera.main.ScreenToViewportPoint(touch.position);
            Vector2 TouchPos = new Vector2(StartPos.x, StartPos.y);
            Collider2D TouchObject = Physics2D.OverlapPoint(TouchPos);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    Start2D = TouchPos;
                    NowSwipe = true;
                    break;

                case TouchPhase.Moved:
                    Moving = TouchPos;
                    CameraOnSelect.CameraMoving();
                    break;

                case TouchPhase.Ended:
                    End2D = TouchPos;

                    SwipeSound.Play();


                    if (End2D.x - Start2D.x > 5)
                    {
                        SoundManager.PreviewStop();

                        if (SelectSingleton.StageNum == 9)
                        {
                            SelectSingleton.StageNum = 0;
                        }
                        else { SelectSingleton.StageNum++; }

                        CameraOnSelect.StageCameraPlus();

                        SoundManager.PreviewStart();
                    }
                    if (End2D.x - Start2D.x > -5)
                    {
                        SoundManager.PreviewStop();

                        if (SelectSingleton.StageNum == 0)
                        {
                            SelectSingleton.StageNum = 9;
                        }
                        else { SelectSingleton.StageNum--; }

                        CameraOnSelect.StageCameraMinus();

                        SoundManager.PreviewStart();
                    }



                    NowSwipe = false;
                    break;

            }
        }
    }
}
