
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : Singleton<Player>
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
    void Update()
    {
        this.transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0, 0);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -playerbounds.x, playerbounds.x), transform.position.y, transform.position.z);
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Ground") darfspringen = true;

        if((collision.gameObject.name.Equals("Platform01"))|| (collision.gameObject.name.Equals("platformA")) ||
            (collision.gameObject.name.Equals("platformB")) || (collision.gameObject.name.Equals("platformC")))
        {
            this.transform.parent = collision.transform;
        }

        if((transform.position.x <= -playerbounds.x) && (collision.transform.tag == "Ground") && !(collision.transform.position.y < transform.position.y))
        {
            SceneManager.LoadScene("StartScene");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if((collision.gameObject.name.Equals("Platform01")) || (collision.gameObject.name.Equals("platformA")) || 
        (collision.gameObject.name.Equals("platformB")) || (collision.gameObject.name.Equals("platformC")))
        {
            this.transform.parent = null;
        }
    }
}
