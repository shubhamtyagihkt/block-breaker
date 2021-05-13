﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float minPos = 1f;
    [SerializeField] float maxPos = 15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePositionInUnit = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 paddlePosition = new Vector2(mousePositionInUnit, transform.position.y);
        paddlePosition.x = Mathf.Clamp(paddlePosition.x, minPos, maxPos);
        transform.position = paddlePosition;
    }
}
