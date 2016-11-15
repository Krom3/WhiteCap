using UnityEngine;
using System.Collections;

public class Jobshowcharacter_script : MonoBehaviour
{
    public Sprite MainCharacter_s_C;
    public Sprite MainCharacter_s_B;
    public Sprite MainCharacter_s_A;
    public Sprite MainCharacter_s_S;
    public Sprite MainCharacter_a_C;
    public Sprite MainCharacter_a_B;
    public Sprite MainCharacter_a_A;
    public Sprite MainCharacter_a_S;
    public Sprite MainCharacter_e_C;
    public Sprite MainCharacter_e_B;
    public Sprite MainCharacter_e_A;
    public Sprite MainCharacter_e_S;
    private SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start ()
    {

        //salaried

        if (Jobrandomize_script.showjop == "c_salaried")
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = MainCharacter_s_C;
        }
        if (Jobrandomize_script.showjop == "b_salaried")
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = MainCharacter_s_B;
        }
        if (Jobrandomize_script.showjop == "a_salaried")
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = MainCharacter_s_A;
        }
        if (Jobrandomize_script.showjop == "s_salaried")
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = MainCharacter_s_S;
        }

        //army

        if (Jobrandomize_script.showjop == "c_army")
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = MainCharacter_a_C;
        }
        if (Jobrandomize_script.showjop == "b_army")
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = MainCharacter_a_B;
        }
        if (Jobrandomize_script.showjop == "a_army")
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = MainCharacter_a_A;
        }
        if (Jobrandomize_script.showjop == "s_army")
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = MainCharacter_a_S;
        }

        //entertainer

        if (Jobrandomize_script.showjop == "c_entertainer")
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = MainCharacter_e_C;
        }
        if (Jobrandomize_script.showjop == "b_entertainer")
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = MainCharacter_e_B;
        }
        if (Jobrandomize_script.showjop == "a_entertainer")
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = MainCharacter_e_A;
        }
        if (Jobrandomize_script.showjop == "s_entertainer")
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = MainCharacter_e_S;
        }

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
