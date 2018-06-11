using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PanelTouch : MonoBehaviour  //터치 판넬에 붙이기
{
    public static float TouchPressure;

    EffectManager effectManager;

    public static bool isTouch = false;

    public CircleCollider2D PerfectCollider;
    public CircleCollider2D GreatCollider;

    VerdictEffect verdictEffect;
    public void Awake()
    {
        effectManager = GetComponentInChildren<EffectManager>();

        PerfectCollider.enabled = false;
        GreatCollider.enabled = false;

    }

    public void Update()
    {
        if (Application.platform != RuntimePlatform.Android)
        {
            if (Input.GetMouseButtonDown(0))
            {
             
                    PerfectCollider.enabled = true;
                    GreatCollider.enabled = true;
                    VerdictPressure.OnTouched = true;
                    isTouch = true;
            }
            if(Verdict.EndVerdict == true)
            {
                PerfectCollider.enabled = false;
                GreatCollider.enabled = false;
                VerdictPressure.OnTouched = false;
                Verdict.EndVerdict = false;
            }
        }


        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            TouchPressure = Input.GetTouch(0).pressure;

            effectManager.StartEffect("Touched");
            for (int i = 0; i < Input.touchCount; i++)
            {
                switch (touch.phase)
                {
                    case TouchPhase.Began:
                        PerfectCollider.enabled = true;
                        PerfectCollider.gameObject.SetActive(true);
                        GreatCollider.enabled = true;
                        VerdictPressure.OnTouched = true;
                        isTouch = true;
                        break;
                    case TouchPhase.Stationary:
                        if (isTouch == false)
                        {
                            PerfectCollider.enabled = false;
                            GreatCollider.enabled = false;
                            VerdictPressure.OnTouched = false;
                        }
                        break;
                    case TouchPhase.Ended:
                        PerfectCollider.enabled = false;
                        GreatCollider.enabled = false;
                        VerdictPressure.OnTouched = false;
                        break;
                }
            }
        }
    }
}
