using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Capture4button_script : MonoBehaviour
{
    public Sprite capture_clear4;
    private SpriteRenderer spriteRenderer;
    public static bool stage4_clear;
    public AudioSource Capture4CS;

    // Use this for initialization
    void Start()
    {

    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0) && LeftBackgruond_script.stageclear == 3)
        {
            Capture4CS.Play();
            Capture_script.stagenum = 4;
            StageQuestion_script.StageQuestionoff = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (LeftBackgruond_script.stageclear >= 4)
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = capture_clear4;
        }
        else
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = LeftBackgruond_script.basicstage;
        }

    }
}
