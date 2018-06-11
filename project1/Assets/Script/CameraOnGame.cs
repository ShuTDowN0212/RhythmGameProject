using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class CameraOnGame : MonoBehaviour
{
    public static GameObject SubCamera;
    public GameObject SubCamera_;

    public void Awake()
    {
        SubCamera = SubCamera_;
        SubCamera.SetActive(false);
    }

    public static void StopCamera()
    {
        SubCamera.SetActive(true);
    }

    public static void ResumeCamera()
    {
        SubCamera.SetActive(false);
    }
}