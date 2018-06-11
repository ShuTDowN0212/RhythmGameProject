using System;
using System.Collections.Generic;
using UnityEngine;

public class EndBlock : MonoBehaviour //게임 끝낼때 내려오는 마지막 블록
{
    public void Start()
    {
       
    }

    public void OnTriggerEnter(Collider EndBlock)
    {
        if (EndBlock.gameObject.tag == "EndBlock") { Invoke("LoadScene.GameEndFun();", 3); }
    }
}