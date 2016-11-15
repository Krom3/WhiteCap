using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Capture5button_script : MonoBehaviour
{



    public Sprite capture_clear5;
    private SpriteRenderer spriteRenderer;
    public static bool stage5_clear;
    public AudioSource Capture5CS;

    // Use this for initialization
    void Start()
    {

    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0) && LeftBackgruond_script.stageclear == 4)
        {
            Capture5CS.Play();
            Capture_script.stagenum = 5;
            StageQuestion_script.StageQuestionoff = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (LeftBackgruond_script.stageclear >= 5)
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = capture_clear5;
        }
        else
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = LeftBackgruond_script.basicstage;
        }

    }
}
