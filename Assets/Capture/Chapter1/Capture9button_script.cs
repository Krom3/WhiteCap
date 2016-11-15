using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Capture9button_script : MonoBehaviour
{



    public Sprite capture_clear9;
    private SpriteRenderer spriteRenderer;
    public static bool stage9_clear;
    public AudioSource Capture9CS;

    // Use this for initialization
    void Start()
    {

    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0) && LeftBackgruond_script.stageclear == 8)
        {
            Capture9CS.Play();
            Capture_script.stagenum = 9;
            StageQuestion_script.StageQuestionoff = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (LeftBackgruond_script.stageclear >= 9)
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = capture_clear9;
        }
        else
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = LeftBackgruond_script.basicstage;
        }

    }
}
