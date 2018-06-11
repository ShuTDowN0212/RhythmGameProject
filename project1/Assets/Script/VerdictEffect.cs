using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VerdictEffect : MonoBehaviour
{
    public Image PerfectP;
    public Image GreatP;
    public Image MissP;

    public Image PerfectG;
    public Image GreatG;
    public Image MissG;

    public Image PerfectM;
    public Image GreatM;
    public Image MissM;

    private Image NowImage;

    public static int VerdictNum = 0; //판별
    public static int PressNum = 0;



    
    public void ImageMaker()
    {
        if (VerdictNum == 3 && PressNum == 3)
        {
            NowImage.gameObject.SetActive(false);
            NowImage = PerfectP;
            NowImage.gameObject.SetActive(true);
        }
        if (VerdictNum == 3 && PressNum == 32)
        {
            NowImage.gameObject.SetActive(false);
            NowImage = PerfectG;
            NowImage.gameObject.SetActive(true);
        }
        if (VerdictNum == 3 && PressNum == 1)
        {
            NowImage.gameObject.SetActive(false);
            NowImage = PerfectM;
            NowImage.gameObject.SetActive(true);
        }
        if (VerdictNum == 2 && PressNum == 3)
        {
            NowImage.gameObject.SetActive(false);
            NowImage = GreatP;
            NowImage.gameObject.SetActive(true);
        }
        if (VerdictNum == 2 && PressNum == 2)
        {
            NowImage.gameObject.SetActive(false);
            NowImage = GreatG;
            NowImage.gameObject.SetActive(true);
        }
        if (VerdictNum == 2 && PressNum == 1)
        {
            NowImage.gameObject.SetActive(false);
            NowImage = GreatM;
            NowImage.gameObject.SetActive(true);
        }
        if (VerdictNum == 1 && PressNum == 3)
        {
            NowImage.gameObject.SetActive(false);
            NowImage = MissP;
            NowImage.gameObject.SetActive(true);
        }
        if (VerdictNum == 1 && PressNum == 2)
        {
            NowImage.gameObject.SetActive(false);
            NowImage = MissG;
            NowImage.gameObject.SetActive(true);
        }
        if (VerdictNum == 1 && PressNum == 1)
        {
            NowImage.gameObject.SetActive(false);
            NowImage = MissG;
            NowImage.gameObject.SetActive(true);
        }
    }




}
