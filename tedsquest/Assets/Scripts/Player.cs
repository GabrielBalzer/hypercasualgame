using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float jump;
    public bool darfspringen = true;
    public Vector2 playerbounds;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if ((transform.position.x < -playerbounds.x) || (transform.position.x > playerbounds.x))
        {

            this.transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0, 0);
            if (Input.GetMouseButton(0))
            {
                if (Input.mousePosition.x < Camera.main.pixelWidth / 2)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * speed);
                }
                else
                {
                    transform.Translate(Vector3.right * Time.deltaTime * speed);
                }
            }
            if (Input.GetKeyDown(KeyCode.Space) && darfspringen)
            {
                GetComponent<Rigidbody2D>().AddForce(Vector2.up * jump);
                darfspringen = false;
            }
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        darfspringen = true;
        if(collision.gameObject.name.Equals("Platform01"))
        {
            this.transform.parent = collision.transform;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.name.Equals("Platform01"))
        {
            this.transform.parent = null;
        }
    }
}
