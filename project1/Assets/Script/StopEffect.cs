using System;
using System.Collections;
using UnityEngine;

//Effect 하위에 Touched라고 하나 더 만들어서 해당스크립트 사용

public class StopEffect : MonoBehaviour
{
    public float MainTainSec = 0.5f;

    void OnEnable()
    {
        StartCoroutine(EffectStop());  
    }

    public IEnumerator EffectStop()
    {
        yield return new WaitForSeconds(MainTainSec);
        gameObject.SetActive(false);
    }
}