using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Example_DoTween_Jump : MonoBehaviour
{
    [Range(1, 7f)] public float power;
    [Range(1, 2f)] public int jumpnum;
    [Range(1, 5f)] public float duration;

    void Start()
    {
        DOTween.Init();
    }


    public void Jump()
    {
        transform.DOLocalJump(transform.position, power, jumpnum, duration).OnComplete<Tween>(Grounded);
    }

    void Grounded()
    {
        transform.position = Vector3.zero;
    }
}
