using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchEffect : MonoBehaviour
{
    [SerializeField] private GameObject TouchShadow;

    public static GameObject GG;

    void Awake()
    {
    }

    void Start()
    {
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            TouchShadow.transform.position = GG.transform.position;

            Color Opercity = TouchShadow.GetComponent<Renderer>().material.color;
            Opercity.a = 0.5f;
            
            for (int i = 0; i<10; i++)
            {
                Opercity.a -= 0.1f;

                if (Opercity.a == 0.1f) TouchShadow.SetActive(false); Destroy(this);
            }
        }
    }
}
