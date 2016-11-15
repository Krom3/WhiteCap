using UnityEngine;
using System.Collections;

public class Revive_coloor : MonoBehaviour
{
    public float LoadingTime = 0.1f;
    SpriteRenderer render;

    void Start()
    {
        render = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        LoadingTime -= Time.deltaTime;
        if (LoadingTime < 0)
        {
            render.color = new Color(render.color.r,render.color.b,render.color.g,Random.value+0.4f);
            LoadingTime = 0.1f;
        }
    }
}