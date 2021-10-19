using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottomtriggerinfo : MonoBehaviour
{
    public GameObject loseScene;
    public GameObject loseRetry;
    bool gameover = false;
    public AudioSource backgroundmusic;

    private void Update()
    {
        if (gameover)
            Time.timeScale = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("platform"))
        {
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("Player"))
        {
            loseScene.SetActive(true);
            loseRetry.SetActive(true);
            Destroy(collision.gameObject);
            gameover = true;
            backgroundmusic.volume=0.05f;
        }
    }
}
