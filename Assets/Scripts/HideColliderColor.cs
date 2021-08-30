using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class HideColliderColor : MonoBehaviour
{
    private TilemapRenderer tilemapRender;

    // Start is called before the first frame update
    private void Awake()
    {
        tilemapRender = GetComponent<TilemapRenderer>();
    }

    private void Start()
    {
        tilemapRender.enabled = false;
    }
}
