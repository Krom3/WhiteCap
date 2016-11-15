using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Capture6button_script : MonoBehaviour
{



    public Sprite capture_clear6;
    private SpriteRenderer spriteRenderer;
    public static bool stage6_clear;
    public AudioSource Capture6CS;

    // Use this for initialization
    void Start()
    {

    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0) && LeftBackgruond_script.stageclear == 5)
        {
            Capture6CS.Play();
            Capture_script.stagenum = 6;
            StageQuestion_script.StageQuestionoff = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (LeftBackgruond_script.stageclear >= 6)
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = capture_clear6;
        }
        else
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = LeftBackgruond_script.basicstage;
        }

    }
}
