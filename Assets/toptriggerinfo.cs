using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toptriggerinfo : MonoBehaviour
{
    public GameObject winScene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.CompareTag("Player"))
        //{
        //    winScene.SetActive(true);
        //    Destroy(collision.gameObject);
        //}
    }
}
