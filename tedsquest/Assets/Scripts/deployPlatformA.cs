using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployPlatformA : MonoBehaviour
{
    public GameObject platformAPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;
    private Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(PlatformAWave());
    }

    private void spawnPlatformA()
    {
        GameObject a = Instantiate(platformAPrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * -1, UnityEngine.Random.Range((float)0.7, (screenBounds.y/2)));
    }

    IEnumerator PlatformAWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnPlatformA();
        }
    }
}
