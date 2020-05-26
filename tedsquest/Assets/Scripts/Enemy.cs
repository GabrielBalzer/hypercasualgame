using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Singleton<Enemy>
{
    private float life;
    private float position_x;
    private float position_y;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Start( float lf)
    {
        life = lf;
    }

    void Start(float lf, float posX, float posY)
    {
        life = lf;
        position_x = posX;
        position_y = posY;
    }
    // Update is called once per frame
    public void FixedUpdate()
    {
        
    }

    public float getlife()
    {
        return life;
    }

    public float getposition_x()
    {
        return position_x;
    }

    public float getposition_y()
    {
        return position_y;
    }

    public void destroy()
    {

    }
}
