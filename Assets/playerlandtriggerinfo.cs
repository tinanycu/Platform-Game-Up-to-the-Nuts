using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerlandtriggerinfo : MonoBehaviour
{
    public playerinfo playerinfo;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("platform"))
        {
            playerinfo.isLand = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("platform"))
        {
            playerinfo.isLand = false;
        }
        
    }
}
