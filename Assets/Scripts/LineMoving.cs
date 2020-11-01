﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineMoving : MonoBehaviour
{
    public float movingSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, 0, (movingSpeed * Time.deltaTime) * 10);
    }
}
