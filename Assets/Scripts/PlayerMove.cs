using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public int playerHp = 10;
    public float moveDist = 1f;
    public float limitX;
    public GameObject deadEffect;
    public GameObject gameover;
    public GameObject hitEffect;
    public Slider hpBar;
    public Jun_TweenRuntime junL;
    public Jun_TweenRuntime junR;
    

    void Start()
    {
        hpBar = GameObject.Find("HpBar").GetComponent<Slider>();
    }


    void Update()
    {
        hpBar.value = playerHp;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            LeftMove();
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            RightMove();
        }
    }
    public void LeftMove()
    {
        transform.position -= new Vector3(moveDist, 0, 0);
        if (transform.position.x <= -limitX)
        {
            transform.position = new Vector3(-limitX, 0, 0);
            
        }
    }
    public void RightMove()
    {
        transform.position += new Vector3(moveDist, 0, 0);
        if(transform.position.x >= limitX)
        {
            transform.position = new Vector3(limitX, 0, 0);
            
        }
    }

    private void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject.tag == "Enemy")
        {
            Instantiate(hitEffect, transform.position, transform.rotation);
            playerHp--;
            Destroy(coll.gameObject);
            if(playerHp <= 0)
            {
                Instantiate(deadEffect, transform.position, transform.rotation);
                Destroy(gameObject);
                gameover.gameObject.SetActive(true);
            }
        }
    }
}
