using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Example_Dotween_Path : MonoBehaviour
{
    public GameObject[] path;
    public Vector3[] tweenPath;
    public Transform target;
    public Sequence mySequence;

    void Start()
    {
        DOTween.Init();
        path = GameObject.FindGameObjectsWithTag("Path");
        for (int i = 0; i < path.Length; i++)
        {
            tweenPath[i] = path[i].transform.position;
        }

        mySequence = DOTween.Sequence();
        mySequence.Append(transform.DOPath(tweenPath, 10f)).Pause();
    }

    public void TweenPlay()
    {
        //mySequence.PlayForward();
        transform.DOPath(tweenPath, 10f).SetLookAt(target.position,true).Play().OnComplete(CompleteTween);
    }

    public void TweenBack()
    {
        //mySequence.PlayBackwards();
        transform.DOPath(tweenPath, 10f).SetLookAt(target.position, true).SetInverted().OnComplete(() =>
        Debug.Log("Tween Complete"));
    }

    public void CompleteTween()
    {
        Debug.Log("트윈 완료");
    }
}
