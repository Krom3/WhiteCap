using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Capture1button_script : MonoBehaviour {



    public Sprite capture_clear1;
    private SpriteRenderer spriteRenderer;
    public static bool stage1_clear;
    public AudioSource Capture1CS;

    // Use this for initialization
    void Start () {

    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0) && LeftBackgruond_script.stageclear < 1)
        {
            Capture_script.stagenum = 1;
            Capture1CS.Play();
            StageQuestion_script.StageQuestionoff = true;

        }
    }

    // Update is called once per frame
    void Update ()
    {
        if (LeftBackgruond_script.stageclear >= 1)
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