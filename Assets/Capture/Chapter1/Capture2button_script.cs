using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Capture2button_script : MonoBehaviour
{



    public Sprite capture_clear2;
    private SpriteRenderer spriteRenderer;
    public static bool stage2_clear;
    public AudioSource Capture2CS;

    // Use this for initialization
    void Start()
    {

    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0) && LeftBackgruond_script.stageclear == 1)
        {
            Capture2CS.Play();
            Capture_script.stagenum = 2;
            StageQuestion_script.StageQuestionoff = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (LeftBackgruond_script.stageclear >= 2)
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = capture_clear2;
        }
        else
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = LeftBackgruond_script.basicstage;
        }

    }
}
