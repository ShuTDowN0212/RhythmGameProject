using System;
using System.Collections.Generic;
using UnityEngine;


public class EffectManager : MonoBehaviour
{
    public List<Transform> effects;
    
    //이펙트는 노트에 차일드로 Effect란 이름으로 넣고 Element에 이펙트 넣기


    public void StartEffect(string effectName)
    {
        for(int i = 0; i<effects.Count; i++)
        {

            //인자값과 리스트의 i와 이름 확인
            if(effects[i].name.CompareTo(effectName) == 0)
            {
                effects[i].gameObject.SetActive(false);
                effects[i].gameObject.SetActive(true);
            }
        }
    }
    private void Start()
    {
        
    }
}
