using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScreenEffect : MonoBehaviour //기타 이펙트 등등 에 사용
{
    public GameObject Effect;
    private GameObject EffectInstant;

    public void Awake()
    {
        Effect.SetActive(false);
    }

    public void EffectOn()
    {
        EffectInstant = Instantiate(Effect, transform.position, Effect.transform.rotation);
        EffectInstant.SetActive(true);
        Destroy(EffectInstant.gameObject, 0.5f);
    }
}
