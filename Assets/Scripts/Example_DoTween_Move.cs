using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Example_DoTween_Move : MonoBehaviour
{

    void Start()
    {
        DOTween.Init();

    }

    public void MoveRight()
    {
        transform.DOMoveX(8f, 1f);
    }

    public void MoveLeft()
    {
        transform.DOMoveX(-8f, 1f);
    }

    public void RotateRight()
    {
        transform.DORotate(new Vector3(0, 270, 0), 1f, RotateMode.Fast);
    }

    public void RotateLeft()
    {
        transform.DORotate(new Vector3(0, -270, 0), 1f, RotateMode.Fast);
    }
}
