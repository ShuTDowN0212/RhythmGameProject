using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notes1 : MonoBehaviour  //노트 파괴 스크립트
{

    public GameObject NotePrefab = null;


    private void Awake()
    {

    }

    public void FixedUpdate()
    {

        if (PanelTouch.isTouch == true)
        {
            GameObject Note = GameObject.Instantiate(NotePrefab) as GameObject;

            if(Note.tag == "Note")
            {
                DestroyImmediate(this);
            }
        }

    }



}
