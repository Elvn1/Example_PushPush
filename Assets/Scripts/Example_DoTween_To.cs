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
        
        //1. To() �ȿ��� �͸��Լ� ȣ��
        //2. myFloat�� ���� ���
        //3. x �Ű������ myFloat�� �����ڴ´�
        //4. ��ǥ���� ()
        //5. duration(�ð�)
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
