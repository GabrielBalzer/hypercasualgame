using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : Singleton<PowerUps>
{

    private float position_x;
    private float position_y;
    private int content;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    public float getposition_x()
    {
        return position_x;
    }

    public float getposition_y()
    {
        return position_y;
    }

    public int getcontent()
    {
        return content;
    }

    public void destroy()
    {

    }
}
