using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    public float jump;
    public bool darfspringen = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        this.transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0,0);
        if(Input.GetMouseButton(0))
        {
            if(Input.mousePosition.x < Camera.main.pixelWidth / 2)
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
            else
            {
                transform.Translate(Vector3.right * Time.deltaTime * speed);
            }
        }
        if(Input.GetKeyDown(KeyCode.Space) && darfspringen)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jump);
            darfspringen = false;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        darfspringen = true;
    }
}
