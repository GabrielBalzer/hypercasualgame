﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class scoreCount : MonoBehaviour
{ 
    public static int scoreValue = 0;
    private Text score;

    // Start is called before the first frame update
    void Start()
    {
    score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
    score.text = "Score: " + scoreValue;
    }
}
