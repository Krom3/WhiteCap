﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Capture1button2_script : MonoBehaviour
{



    public Sprite capture_clear1;
    private SpriteRenderer spriteRenderer;
    public static bool stage21_clear;


    // Use this for initialization
    void Start()
    {

    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0) && LeftBackgruond_script.stageclear == 9)
        {
            Capture_script.stagenum = 21;
            StageQuestion_script.StageQuestionoff = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (LeftBackgruond_script.stageclear >= 21)
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = capture_clear1;
        }
        else
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = LeftBackgruond_script.basicstage;
        }

    }
}