using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Capture7button_script : MonoBehaviour
{



    public Sprite capture_clear7;
    private SpriteRenderer spriteRenderer;
    public static bool stage7_clear;
    public AudioSource Capture7CS;

    // Use this for initialization
    void Start()
    {

    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0) && LeftBackgruond_script.stageclear == 6)
        {
            Capture7CS.Play();
            Capture_script.stagenum = 7;
            StageQuestion_script.StageQuestionoff = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (LeftBackgruond_script.stageclear >= 7)
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = capture_clear7;
        }
        else
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = LeftBackgruond_script.basicstage;
        }

    }
}
