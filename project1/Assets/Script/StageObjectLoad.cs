using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageObjectLoad : MonoBehaviour {


    public Button StartButton;

    public static List<Button> StartButtonList = new List<Button>();
    // Use this for initialization
    private void Awake()
    {
        StartButtonList.Add(StartButton);
        StartButtonList.Add(StartButton);
        StartButtonList.Add(StartButton);
        StartButtonList.Add(StartButton);
        StartButtonList.Add(StartButton);
        StartButtonList.Add(StartButton);
        StartButtonList.Add(StartButton);
        StartButtonList.Add(StartButton);
        StartButtonList.Add(StartButton);
        StartButtonList.Add(StartButton);

    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
