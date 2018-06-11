using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerdictPressure : MonoBehaviour { //감압 판정 //노트에 연결


    public static Collider2D other;

    public static float VerdictPress;


    public static bool OnTouched = false;

    public static float FortePress = 1.8f;
    public static float MezopianoPress = 1.2f;
    public static float PianoPress = 0.6f;


    // Use this for initialization
    void Start () {
        other = GetComponent<Collider2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (OnTouched == true)
        {
            VerdictPress = PanelTouch.TouchPressure;
        }
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Forte")
        {
            if( VerdictPress - FortePress <= 0.1f || VerdictPress - FortePress >= -0.1f)
            {
                PressureCombo.PressPerfect();
                Singletons.PerfectP++;
                VerdictEffect.PressNum = 3;
            }

            else if (VerdictPress - FortePress <= 0.3f || VerdictPress - FortePress >= -0.3f)
            {
                PressureCombo.PressGreat();
                Singletons.GreatP++;
                VerdictEffect.PressNum = 2;
            }

            else
            {
                PressureCombo.PressMiss();
                Singletons.MissP++;
                VerdictEffect.PressNum = 1;
            }
        }

        if (other.gameObject.tag == "MezoPiano")
        {
            if (VerdictPress - MezopianoPress <= 0.1f || VerdictPress - MezopianoPress >= -0.1f)
            {
                PressureCombo.PressPerfect();
                Singletons.PerfectP++;
                VerdictEffect.PressNum = 3;
            }

            else if (VerdictPress - MezopianoPress <= 0.3f || VerdictPress - MezopianoPress >= -0.3f)
            {
                PressureCombo.PressGreat();
                Singletons.GreatP++;
                VerdictEffect.PressNum = 2;
            }

            else
            {
                PressureCombo.PressMiss();
                Singletons.MissP++;
                VerdictEffect.PressNum = 1;
            }
        }

        if (other.gameObject.tag == "Piano")
        {
            if (VerdictPress - PianoPress <= 0.1f || VerdictPress - PianoPress >= -0.1f)
            {
                PressureCombo.PressPerfect();
                Singletons.PerfectP++;
                VerdictEffect.PressNum = 3;
            }

            else if (VerdictPress - PianoPress <= 0.3f || VerdictPress - PianoPress >= -0.3f)
            {
                PressureCombo.PressGreat();
                Singletons.GreatP++;
                VerdictEffect.PressNum = 2;
            }

            else
            {
                PressureCombo.PressMiss();
                Singletons.MissP++;
                VerdictEffect.PressNum = 1;
            }
        }
    }
}
