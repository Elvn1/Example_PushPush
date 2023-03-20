using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ground : MonoBehaviour
{
    public int cnt;
    public Jun_TweenRuntime tween;
    public Text scoreTxt;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            cnt++;
            scoreTxt.text = cnt.ToString();
            tween.Play();
            Destroy(collision.gameObject);
        }
    }
}
