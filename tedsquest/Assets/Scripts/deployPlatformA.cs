using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployPlatformA : MonoBehaviour
{
    public GameObject platformAPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(PlatformAWave());
        //Update();
    }

    private void spawnPlatformA()
    {
        GameObject a = Instantiate(platformAPrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * -(float)Convert.ToDouble(0.5), UnityEngine.Random.Range(-screenBounds.y, screenBounds.y));
    }

    IEnumerator PlatformAWave()
    //void Update()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnPlatformA();
        }
    }
}
