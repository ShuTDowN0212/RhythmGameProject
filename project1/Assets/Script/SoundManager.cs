using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
   




    public GameObject GameMenu; //panel for music and start
    public GameObject SoundMenu; // panel for audio settings
    public static AudioSource MainMusic_01;
    public static AudioSource StartSound;

    int SoundNum;

    private void Start()
    {
        AudioListener.volume = (float)volume;
    }

    public static void GameMenuOn()
    {
        //  GameMenu.SetActive(true);
        MainMusic_01.Play();
    }

    public static void GameMenuOff()
    {
        //    GameMenu.SetActive(false);
        MainMusic_01.Stop();
    }
    public static void GameStart01(){
        GameObjectLoad.GameMusic[SelectSingleton.NoteNum].Play();
    }
    public static void GameExit01(){
        GameObjectLoad.GameMusic[SelectSingleton.NoteNum].Stop();
    }
    public static void GamePause()
    {
        GameObjectLoad.GameMusic[SelectSingleton.NoteNum].Pause();
    }
    public static void GameUnpause()
    {
        GameObjectLoad.GameMusic[SelectSingleton.NoteNum].UnPause();
    }


    public static void PreviewStart()
    {
        GameObjectLoad.PreView[SelectSingleton.StageNum].Play();
    }

    public static void PreviewStop()
    {
        GameObjectLoad.PreView[SelectSingleton.StageNum].Stop();
    }





    public static void Stop()
    {
        Time.timeScale = 0;
    }

    public static void Resume()
    {
        Time.timeScale = 1;
    }
    public static void PlaySound(string SoundName)
    {
        GameObject.Find(SoundName).GetComponent<AudioSource>().Play();
    }









    static public double volume = 1;

    public void SoundVolumeUp()
    {
        volume = volume + 0.1;

        if (volume < 2)
            AudioListener.volume = AudioListener.volume + 0.1f;
        Debug.Log("Up");
    }

    public void SoundVolumeDown()
    {
        volume = volume - 0.1;

        if (volume > 0)
            AudioListener.volume = AudioListener.volume - 0.1f;
        Debug.Log("Down");
    }

    public void SoundVolumeOn()
    {
        AudioListener.volume = (float)volume;
    }

    public void SoundVolumeOff()
    {
        AudioListener.volume = 0;

    }

}

