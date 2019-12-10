using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour
{
    private float position_x;
    private float position_y;
    private int urban_type;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Start(float posX, float posY, int ut)
    {
        position_x = posX;
        position_y = posY;
        urban_type = ut;
    }

    // Update is called once per frame
    public void FixedUpdate()
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

    public int geturban_type()
    {
        return urban_type;
    }
}
