using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Example_DoTween_To : MonoBehaviour
{
    public Slider hpBar;
    [Range(0,1)]
    public float myFloat;

    void Start()
    {
        hpBar = GetComponent<Slider>();
        DOTween.Init();
        
        //1. To() 안에서 익명함수 호출
        //2. myFloat은 변경 대상
        //3. x 매계번수에 myFloat을 때려박는다
        //4. 목표값은 ()
        //5. duration(시간)
    }

    public void MinusHpBar(float m)
    {
        DOTween.To(() => hpBar.value, x => hpBar.value = x, hpBar.value - 0.2f, m);
    }

    public void PlusHpBar(float p)
    {
        DOTween.To(() => hpBar.value, x => hpBar.value = x, hpBar.value + 0.1f, p);
    }

    //private void Update()
    //{
    //    hpBar.value = myFloat;
    //}
}
