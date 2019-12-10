using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Player.cs;

public class World : MonoBehaviour
{

    private int background;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Start(int bg)
    {
        background = bg;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    public int getbackground()
    {
        return background;
    }

    public void generatePlatforms()
    {

    }

    public void generateEnemy()
    {

    }

    public void generatePlayer()
    {

    }

    public void generatePowerUps()
    {

    }

    public void Destroy()
    {

    }


}
