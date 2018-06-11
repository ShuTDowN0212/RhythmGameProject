using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameObjectLoad : MonoBehaviour
{

    public static AudioSource StartSound;



    //Game Ost
    public AudioSource GM00;
    public AudioSource GM01;
    public AudioSource GM02;
    public AudioSource GM03;
    public AudioSource GM04;
    public AudioSource GM05;
    public AudioSource GM06;
    public AudioSource GM07;
    public AudioSource GM08;
    public AudioSource GM09;

    //List GameMusic
    public static List<AudioSource> GameMusic = new List<AudioSource>();



    public AudioSource Pre00;
    public AudioSource Pre01;
    public AudioSource Pre02;
    public AudioSource Pre03;
    public AudioSource Pre04;
    public AudioSource Pre05;
    public AudioSource Pre06;
    public AudioSource Pre07;
    public AudioSource Pre08;
    public AudioSource Pre09;

    public static List<AudioSource> PreView = new List<AudioSource>();

    private void Awake()
    {

        //Add GameMusic List
        GameMusic.Add(GM00);
        GameMusic.Add(GM01);
        GameMusic.Add(GM02);
        GameMusic.Add(GM03);
        GameMusic.Add(GM04);
        GameMusic.Add(GM05);
        GameMusic.Add(GM06);
        GameMusic.Add(GM07);
        GameMusic.Add(GM08);
        GameMusic.Add(GM09);


        //Preview Music List
        PreView.Add(Pre00);
        PreView.Add(Pre01);
        PreView.Add(Pre02);
        PreView.Add(Pre03);
        PreView.Add(Pre04);
        PreView.Add(Pre05);
        PreView.Add(Pre06);
        PreView.Add(Pre07);
        PreView.Add(Pre08);
        PreView.Add(Pre09);

        DontDestroyOnLoad(this.gameObject);

    }

}
 
