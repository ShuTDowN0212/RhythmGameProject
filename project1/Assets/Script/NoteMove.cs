using System;
using System.Collections;
using UnityEngine;


public class NoteMove : MonoBehaviour   //노트에 붙여야됨 Devel이 우리가 정하는 기본적인 속도
{
    public static int SetSpeed;
    public static float Devel = 10;

    public Vector3 PSpeed = new Vector3(0, Devel * SetSpeed, 0);

    void Awake()
    {
        SetSpeed = Option.UserSpeed;
    }

    public void FixedUpdate()
    {
        this.NoteTrans();
    }

    void NoteTrans()
    {
        this.transform.Translate(Time.deltaTime * PSpeed, Space.World);
    }
}
