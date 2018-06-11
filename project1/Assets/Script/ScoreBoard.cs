using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreBoard : MonoBehaviour  //스코어 보드 관련 스크립트  //문제가 많음
{
    public Button GoToSelect;

    public AudioSource BackSound;
    public AudioClip BackSound_;

    public Text PerfectText; //일반
    public Text GreatText;
    public Text MissText;

    public Text PerfectP; //감압
    public Text GreatP;
    public Text MissP;

    public Text AccuracyText; //현재 Acc
    public Text ComboText; //현재 Combo


    public GameObject GameSingletons = GameObject.Find("Singleton");

    public void Awake()
    {

        ScoreView();
    }
    
    public void Start(){
        BackSound = GetComponent<AudioSource>();
        BackSound.clip = BackSound_;
        BackSound.loop = false;




        }

    public void Update()
    {
        if (GoToSelect && Input.GetMouseButtonDown(0)) { OnClickGoToSelect();  }
    }



    public void OnClickGoToSelect()
    {
        BackSound.Play();

        Destroy(GameSingletons);
        SelectSingleton.SceneName = null;
        SceneManager.LoadScene("SelectStage");
        SaveAndLoadData.LoadData();
    }

    public void ScoreView()
    {
        PerfectText.text = Singletons.perfect.ToString();
        GreatText.text = Singletons.great.ToString();
        MissText.text = Singletons.miss.ToString();

        PerfectP.text = Singletons.PerfectP.ToString();
        GreatP.text = Singletons.GreatP.ToString();
        MissP.text = Singletons.MissP.ToString();

        AccuracyText.text = (Singletons.AllAccuracy + Singletons.AccP).ToString();

    }

    public void ReplayGame()
    {
        BackSound.Play();
        SceneManager.LoadScene("Loading");
    }
}