using System;
using System.Collections.Generic;
using UnityEngine;

public class PressureCombo : MonoBehaviour
{

    public void Awake()
    {
        Singletons.AccP = 0;
    }

    public static void PressPerfect()
    {
        Singletons.PCombo =+ 1;
        Singletons.ComboPoint =+ 0.5f;
        Singletons.AccP = comboAccuracycirculeP(Singletons.NoteCount, Singletons.PCombo);

    }

    public static void PressGreat()
    {
        Singletons.PCombo =+ 1;
        Singletons.ComboPoint = +0.35f;
        Singletons.AccP = comboAccuracycirculeP(Singletons.NoteCount, Singletons.PCombo);

    }

    public static void PressMiss()
    {
        Singletons.PCombo = 0;
        Singletons.ComboPoint = +0.5f;
        Singletons.AccP = comboAccuracycirculeP(Singletons.NoteCount, Singletons.PCombo);

    }


    public static float comboAccuracycirculeP(int Notecnt, float Acombo)
    {
        float temp = 0.00f;
        temp = Acombo / Notecnt;

        return temp;
    }
}