using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Capture8button_script : MonoBehaviour
{



    public Sprite capture_clear8;
    private SpriteRenderer spriteRenderer;
    public static bool stage8_clear;
    public AudioSource Capture8CS;

    // Use this for initialization
    void Start()
    {

    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0) && LeftBackgruond_script.stageclear == 7)
        {
            Capture8CS.Play();
            Capture_script.stagenum = 8;
            StageQuestion_script.StageQuestionoff = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (LeftBackgruond_script.stageclear >= 8)
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = capture_clear8;
        }
        else
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = LeftBackgruond_script.basicstage;
        }

    }
}
