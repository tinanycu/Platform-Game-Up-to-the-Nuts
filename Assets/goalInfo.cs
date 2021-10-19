using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalInfo : MonoBehaviour
{
    public GameObject YOUWIN;
    public GameObject winRestart;
    public AudioSource backgroundmusic;
    bool gameover;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position += new Vector3(0, -2, 0) * Time.deltaTime;
        if (gameover)
            Time.timeScale =  0f;
    }

   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("yes");
            YOUWIN.SetActive(true);
            winRestart.SetActive(true);
            gameover = true;
            backgroundmusic.volume = 0.05f;
        }
    }
}
