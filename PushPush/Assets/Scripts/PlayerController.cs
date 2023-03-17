using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    RaycastHit hit2;

    public GameMgr gameMgr;
    void Start()
    {
        gameMgr = GameObject.Find("GameMgr").GetComponent<GameMgr>();
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            CheckOthers(Vector3.left);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            CheckOthers(Vector3.right);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            CheckOthers(Vector3.forward);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            CheckOthers(Vector3.back);
        }
    }

    public void CheckOthers(Vector3 dir)
    {
        if(Physics.Raycast(transform.position, transform.TransformDirection(dir), out hit, 1.0f))
        {
            Transform tr = hit.collider.transform;
            //Debug.Log(tr.gameObject.tag);
            switch (hit.collider.tag)
            {
                case "Ball":
                    Debug.Log("Ball");
                    if(Physics.Raycast(tr.position, tr.TransformDirection(dir), out hit2, 1.0f))
                    {
                        switch (hit2.collider.tag)
                        {
                            case "Bucket":
                                Debug.Log("2Ä­ µÚ ::" + hit2.collider.tag);
                                break;
                            case "Ball":
                                Debug.Log("2Ä­ µÚ ::" + hit2.collider.tag);
                                break;
                            case "Wall":
                                Debug.Log("2Ä­ µÚ ::" + hit2.collider.tag);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        transform.Translate(dir); //Player
                        tr.Translate(dir); //Player°¡ Raycast¸¦ ½÷¼­ ¸ÂÀº ¾Öµµ °°ÀÌ ÀÌµ¿
                        gameMgr.CheckBallPosition();
                    }
                    break;
                case "Wall":
                    Debug.Log("¸ø °¡");
                    break;
                default:
                    break;
            }
        }
        else
        {
            transform.Translate(dir);
        }
    }
}
