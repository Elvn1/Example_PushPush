using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMaker : MonoBehaviour
{
    public GameObject enemy;
    public float curTime;
    public float coolTime;
    void Start()
    {
        coolTime = Random.Range(2.0f, 5.0f);
    }


    void Update()
    {
        curTime += Time.deltaTime;
        if(curTime > coolTime)
        {
            curTime = 0;
            coolTime = Random.Range(0.5f, 1.0f);
            Instantiate(enemy, transform.position, transform.rotation);
        }
    }
}
