using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combo : MonoBehaviour  //스크립트 이름 그 자체/ 콤보들 관련 함수모음
{




    public void Awake()
    {
        Singletons.AllAccuracy = 0;
    }

    public static void comboperfect(){

        Singletons.combo =+ 1;
        Singletons.NoteCount++;
        Singletons.ComboPoint =+ 0.5f;
        Singletons.AllAccuracy = comboAccuracycircule(Singletons.NoteCount, Singletons.combo);
    }

    public static void combogreat(){
        Singletons.combo = +1;
        Singletons.NoteCount++;
        Singletons.ComboPoint =+ 0.35f;
        Singletons.AllAccuracy = comboAccuracycircule(Singletons.NoteCount,Singletons.combo);
    }

    public static void combomiss(){
        Singletons.combo = 0;
        Singletons.NoteCount++;
        Singletons.ComboPoint =+ 0;
        Singletons.AllAccuracy = comboAccuracycircule(Singletons.NoteCount,Singletons.combo);
    }



    public static float comboAccuracycircule(int Notecnt, float Acombo){
        float temp = 0.00f;
        temp = Acombo / Notecnt;

        return temp;
    }
}
