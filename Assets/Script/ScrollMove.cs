﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollMove : MonoBehaviour {

    public float speed;
        Vector2 offset;
    void Update()
    {
        offset = new Vector2(Time.time * speed, 0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
