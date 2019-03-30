﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int cakeCount1 = 0;
    private int cakeCount2 = 0;
    private int cakeCount3 = 0;
    private int cakeCount4 = 0;

    [SerializeField] private float speed;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    private Animator anim;

    public float duration = 3.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();


    }

    private void Update()
    {

        if (CompareTag("Player1"))
        {
            Vector2 moveInput = new Vector2(Input.GetAxisRaw("1J_MainHorizontal"), Input.GetAxisRaw("1J_MainVertical"));
            moveVelocity = moveInput.normalized * speed;

            if (moveInput.magnitude == 0)
            {
                anim.SetBool("isMoving", false);
            }

            else
            {
                anim.SetBool("isMoving", true);
            }

            if (cakeCount1 > 0 && InputManager.AButton())
            {
                StartCoroutine(speedBoost());
                cakeCount1--;
            }
            if (cakeCount1 > 0 && InputManager.BButton())
            {
                invisible();
            }
        }

        if (CompareTag("Player2"))
        {
            Vector2 moveInput = new Vector2(Input.GetAxisRaw("2J_MainHorizontal"), Input.GetAxisRaw("2J_MainVertical"));
            moveVelocity = moveInput.normalized * speed;

            if (moveInput.magnitude == 0)
            {
                anim.SetBool("isMoving", false);
            }

            else
            {
                anim.SetBool("isMoving", true);
            }

            if (cakeCount2 > 0 && InputManager.AButtonTwo())
            {
                StartCoroutine(speedBoost());
                cakeCount2--;
                Debug.Log("Cookie Success");
            }

            if (InputManager.BButtonTwo())
            {
                Debug.Log(cakeCount2);
            }
        }
        if (CompareTag("Player3"))
        {
            Vector2 moveInput = new Vector2(Input.GetAxisRaw("3J_MainHorizontal"), Input.GetAxisRaw("3J_MainVertical"));
            moveVelocity = moveInput.normalized * speed;

            if (moveInput.magnitude == 0)
            {
                anim.SetBool("isMoving", false);
            }

            else
            {
                anim.SetBool("isMoving", true);
            }

            if (cakeCount3 > 0 && InputManager.AButtonThree())
            {
                StartCoroutine(speedBoost());
                cakeCount3--; 
                Debug.Log("Cookie Success");
            }

            if (InputManager.BButtonThree())
            {
                Debug.Log(cakeCount3);
            }

        }
        if (CompareTag("Player4"))
        {
            Vector2 moveInput = new Vector2(Input.GetAxisRaw("4J_MainHorizontal"), Input.GetAxisRaw("4J_MainVertical"));
            moveVelocity = moveInput.normalized * speed;

            if (moveInput.magnitude == 0)
            {
                anim.SetBool("isMoving", false);
            }

            else
            {
                anim.SetBool("isMoving", true);
            }

            if (cakeCount4 > 0 && InputManager.AButtonFour())
            {
                StartCoroutine(speedBoost());
                cakeCount4--;
                Debug.Log("Cookie Success");
            }

            if (InputManager.BButtonFour())
            {
                Debug.Log(cakeCount4);
            }
        }
    }


    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }

    public void AddCake1()
    {
        cakeCount1++;
    }

    public void AddCake2()
    {
        cakeCount2++;
    }

    public void AddCake3()
    {
        cakeCount3++;
    }

    public void AddCake4()
    {
        cakeCount4++;
    }

    public int GetNumberOfCakes1()
    {
        return cakeCount1;
    }

    public int GetNumberOfCake2()
    {
        return cakeCount2;
    }

    public int GetNumberOfCake3()
    {
        return cakeCount3;
    }

    public int GetNumberOfCake4()
    {
        return cakeCount4;
    }

    // if cakecount <0 and keydown x speed upp i x antal sekunder
    IEnumerator speedBoost()
    {
        speed = 14f;

        yield return new WaitForSeconds(duration);

        speed = 9.0f;
    }

    private void invisible()
    {
        Debug.Log("Invisible");
    }
}


