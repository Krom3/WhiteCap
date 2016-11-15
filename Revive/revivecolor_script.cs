using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class revivecolor_script : MonoBehaviour
{
    public float time=0.1f;
    public Text text;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time < 0)
        {
            text.color = new Color(Random.value, Random.value, Random.value);
            time = Random.Range(0.05f,0.5f);
        }
    }
}
