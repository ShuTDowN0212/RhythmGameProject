using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notes1 : MonoBehaviour  //��Ʈ �ı� ��ũ��Ʈ
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
