using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playereattriggerinfo : MonoBehaviour
{
    public playerinfo playerinfo;
    public GameObject zero;
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public GameObject six;
    public GameObject seven;
    public GameObject eight;
    public GameObject nine;
    public GameObject ten;
    public AudioSource eat;
    public GameObject pressspace;
    public GameObject loseScene;
    public AudioSource backgroundmusic;
    public GameObject loseRetry;
    //bool gameover = false;
    //zero.SetActive(true);
    int score = 0;
    void Start()
    {
        zero.SetActive(true);
    }
    void Update()
    {
        if (playerinfo.isFlying)
        {
            score = 0;
            ten.SetActive(false);
            pressspace.SetActive(false);
            zero.SetActive(true);
            playerinfo.super = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("nut") && !playerinfo.isFlying)
        {
            eat.Play(0);
            Destroy(collision.gameObject);
            //Debug.Log("nut!");
            score++;
            switch (score)
            {
                case 0:
                    ten.SetActive(false);
                    zero.SetActive(true);
                    //playerinfo.super = false;
                    break;
                case 1:
                    zero.SetActive(false);
                    one.SetActive(true);
                    break;
                case 2:
                    one.SetActive(false);
                    two.SetActive(true);
                    break;
                case 3:
                    two.SetActive(false);
                    three.SetActive(true);

                    //score = 0;
                    break;
                case 4:
                    three.SetActive(false);
                    four.SetActive(true);
                    break;
                case 5:
                    four.SetActive(false);
                    five.SetActive(true);
                    break;
                case 6:
                    five.SetActive(false);
                    six.SetActive(true);
                    break;
                case 7:
                    six.SetActive(false);
                    seven.SetActive(true);
                    break;
                case 8:
                    seven.SetActive(false);
                    eight.SetActive(true);
                    break;
                case 9:
                    eight.SetActive(false);
                    nine.SetActive(true);
                    break;
                case 10:
                    nine.SetActive(false);
                    ten.SetActive(true);
                    pressspace.SetActive(true);
                    playerinfo.super = true;

                    //score = 0;
                    break;
            }
        }
        if (collision.CompareTag("harmful") && !playerinfo.isFlying)
        {
            //playerinfo.sr.sprite = sprites[13];
            loseScene.SetActive(true);
            loseRetry.SetActive(true);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            Time.timeScale = 0f;         
            backgroundmusic.volume=0.05f;
        }
    }
    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("nut"))
    //    {
    //        Destroy(collision.gameObject);
    //    }

    //}
}
