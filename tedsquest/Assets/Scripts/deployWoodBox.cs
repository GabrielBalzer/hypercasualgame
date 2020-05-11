using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployWoodBox : MonoBehaviour
{
    public GameObject woodboxPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(WoodBoxWave());
        //Update();
    }

    private void spawnWoodBox()
    {
        GameObject a = Instantiate(woodboxPrefab) as GameObject;
        //a.transform.position = new Vector2(screenBounds.x * -2, Random.Range(-screenBounds.y, screenBounds.y));
        a.transform.position = new Vector2(screenBounds.x * -(float)Convert.ToDouble(0.5), UnityEngine.Random.Range(-screenBounds.y, screenBounds.y));
        //a.transform.position = new Vector2(screenBounds.x * -1, UnityEngine.Random.Range(-screenBounds.y, screenBounds.y));

        //GameObject a = Instantiate(woodboxPrefab) as GameObject;
        //GameObject a = Instantiate<GameObject>(woodboxPrefab);
        //a.transform.position = transform.position + Camera.main.transform.forward * 2;
    }

    IEnumerator WoodBoxWave()
    //void Update()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnWoodBox();
        }
    }
}
