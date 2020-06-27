﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployWoodBox : Singleton<deployWoodBox>
{
    public GameObject woodboxPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(WoodBoxWave());
    }

    private void spawnWoodBox()
    {
        GameObject a = Instantiate(woodboxPrefab) as GameObject;
        //a.transform.position = new Vector2(screenBounds.x * -UnityEngine.Random.Range(0f, 0.75f), UnityEngine.Random.Range(-screenBounds.y, screenBounds.y));
        a.transform.position = new Vector2(screenBounds.x * -1, UnityEngine.Random.Range((float)0.7, (screenBounds.y / 2)));
    }

    IEnumerator WoodBoxWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnWoodBox();
        }
    }
}
