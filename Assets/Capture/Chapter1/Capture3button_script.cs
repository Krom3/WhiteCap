using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Capture3button_script : MonoBehaviour
{



    public Sprite capture_clear3;
    private SpriteRenderer spriteRenderer;
    public static bool stage3_clear;
    public AudioSource Capture3CS;

    // Use this for initialization
    void Start()
    {

    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0) && LeftBackgruond_script.stageclear == 2)
        {
            Capture3CS.Play();
            Capture_script.stagenum = 3;
            StageQuestion_script.StageQuestionoff = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (LeftBackgruond_script.stageclear >= 3)
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = capture_clear3;
        }
        else
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = LeftBackgruond_script.basicstage;
        }

    }
}
