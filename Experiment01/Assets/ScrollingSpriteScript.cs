using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingSpriteScript : MonoBehaviour
{
    public float speed = 0.5f;
    private Vector2 _saved_offset;

    // Start is called before the first frame update
    void Start()
    {
        _saved_offset = GetComponent<Renderer>().material.mainTextureOffset;
    }

    // Update is called once per frame
    void Update()
    {
        float y = Mathf.Repeat(Time.time * speed, 1);
        Vector2 offset = new Vector2(_saved_offset.x, y);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
