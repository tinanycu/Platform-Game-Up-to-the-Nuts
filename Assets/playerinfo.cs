using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class playerinfo : MonoBehaviour
{
    public Rigidbody2D rgb2d;
    float hSpeed;
    float vSpeed;
    float rightEdge;
    float leftEdge;
    float gravity;
    float timer;
    float flyingTime;
    //float flyingTimeRange;

    public bool isLand;
    public bool super;
    public bool startFlying;
    public bool isFlying;
    public SpriteRenderer sr;
    public Sprite[] sprites;
    public bool running;
    //public bool start;
    //public AudioClip impact;
    public AudioSource jump;
    public AudioSource rocket;
    // Start is called before the first frame update
    void Start()
    {
        rgb2d = this.GetComponent<Rigidbody2D>();
        rightEdge = 3.75f;
        leftEdge = -3.75f;
        gravity = 22;
        isLand = false;
        super = false;
        startFlying = false;
        isFlying = false;
        flyingTime = 0;
        //start = false;
        //flyingTimeRange = 0;
        sr = this.GetComponent<SpriteRenderer>();
        //Time.timeScale = 0f;
        //timer.Stop();
        //Console.ReadKey();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("enter"))
        {
            //Time.timeScale = 1f;
            //timer.Start();
            //start = true;
        }
        //if (start == true)
        //{
        timer += Time.deltaTime;
        //}
        if (timer > 0.2f)
        {
            timer = 0;
            running = !running;
        }

        vSpeed = rgb2d.velocity.y - gravity * Time.deltaTime;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            hSpeed = 8;
            if (isLand && running)
                sr.sprite = sprites[1];
            else if (isLand && !running)
                sr.sprite = sprites[2];
            else if (!isLand && rgb2d.velocity.y > 0)
                sr.sprite = sprites[5];
            else if (!isLand && rgb2d.velocity.y < 0)
                sr.sprite = sprites[9];
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            hSpeed = -8;
            if (isLand && running)
                sr.sprite = sprites[3];
            else if (isLand && !running)
                sr.sprite = sprites[4];
            else if (!isLand && rgb2d.velocity.y > 0)
                sr.sprite = sprites[6];
            else if (!isLand && rgb2d.velocity.y < 0)
                sr.sprite = sprites[10];
        }
        else
        {
            hSpeed = 0;
            if (isLand)
                sr.sprite = sprites[0];
        }

        if (isLand && Input.GetKey(KeyCode.UpArrow))
        {

            vSpeed = 23;
            jump.Play(0);
            if (rgb2d.velocity.x == 0)
                sr.sprite = sprites[7];
            else if (rgb2d.velocity.x > 0)
                sr.sprite = sprites[5];
            else if (rgb2d.velocity.x < 0)
                sr.sprite = sprites[6];
        }

        if (this.transform.position.x > rightEdge && hSpeed > 0)
        {
            this.transform.position = new Vector3(leftEdge, this.transform.position.y, this.transform.position.z);
        }
        if (this.transform.position.x < leftEdge && hSpeed < 0)
        {
            this.transform.position = new Vector3(rightEdge, this.transform.position.y, this.transform.position.z);
        }
        
        rgb2d.velocity = new Vector2(hSpeed, vSpeed);
        if (super && Input.GetKey(KeyCode.Space))
        {
            //this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z-0.05f);
            //Physics.IgnoreCollision(this.GetComponent<collider>(), this.GetComponent<collider>());
            rocket.Play(0);
            isFlying = true;
            startFlying = true;
        }
        
        if (isFlying)
        {
            
            sr.sprite = sprites[11];
            //if (startFlying)
            //{
            //    sr.sprite = sprites[11];
            //}           
            flyingTime += Time.deltaTime;
            //flyingTimeRange += Time.deltaTime;
            //if (flyingTimeRange >= 1.5f)
            //{
            //    startFlying = false;
            //    if (sr.sprite == sprites[11])
            //    {
            //        sr.sprite = sprites[12];
            //    }
            //    else
            //    {
            //        sr.sprite = sprites[11];
            //    }
            //    flyingTimeRange = 0;
            //}
            vSpeed = 0.8f;
            GetComponent<Collider2D>().isTrigger = true;
            if (flyingTime >= 5.0f)
            {
                isFlying = false;
                GetComponent<Collider2D>().isTrigger = false;
                flyingTime = 0;
                //jump = GetComponent<AudioSource>();
                
                //flyingTimeRange = 0;
            }
        }
        rgb2d.velocity = new Vector2(hSpeed, vSpeed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("harmful"))
        {
            sr.sprite = sprites[13];
            Debug.Log("lose");
            //Debug.Log("ignore!");
            //Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        if (collision.gameObject.tag == "goal")
        {
            sr.sprite = sprites[14];
            //Debug.Log("ignore!");
            //Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }
}