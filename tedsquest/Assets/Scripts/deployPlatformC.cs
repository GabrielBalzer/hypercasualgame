using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployPlatformC : MonoBehaviour
{
    public GameObject platformCPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(PlatformCWave());
    }

    private void spawnPlatformC()
    {
        GameObject c = Instantiate(platformCPrefab) as GameObject;
        c.transform.position = new Vector2(screenBounds.x * -1, UnityEngine.Random.Range((float)0.7, (screenBounds.y / 2)));
    }

    IEnumerator PlatformCWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnPlatformC();
        }
    }
}
