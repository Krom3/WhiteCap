using UnityEngine;
using System.Collections;

public class Achivemementson_script : MonoBehaviour {

    public AudioSource CS;
    public GameObject Achievements;

    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Achievements.SetActive(true);
            CS.Play();
        }
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

