using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class harmfulnutinfo : MonoBehaviour
{
    float timer;
    int preHole;
    public GameObject harmfulnutTemplate;
    public GameObject goalObject;
    int stageCount = 0;
    public bool stageRender;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(0.08f, 0.08f, 0.08f);
        timer = 0;
        //float xPosition = -3f;
        //GameObject[] newnut1 = new GameObject[5];
        
        //for (int i = 0; i < 5; i++)
        //{
        //    newnut1[i] = Instantiate(nutTemplate, this.transform);
        //    newnut1[i].transform.position = new Vector3(xPosition, 0.4f, 0);
        //    xPosition += 1.5f;
        //}
        //xPosition = -2.25f;
        //GameObject[] newnut2 = new GameObject[4];
        //for (int i = 0; i < 3; i++)
        //{
        //    int nut = Random.Range(0, 3);
        //    if (nut < 2)
        //    {
              
        //        continue;
        //    }
        //    newnut2[i] = Instantiate(harmfulnutTemplate, this.transform);
        //    newnut2[i].transform.position = new Vector3(xPosition, 4.2f, 0);
        //    xPosition += 1.5f;
        //    if (i == 0)
        //    {
        //        xPosition += 1.5f;
        //    }
        //}
        //xPosition = -2.25f;
        //GameObject[] newnut3 = new GameObject[4];
        //for (int i = 0; i < 3; i++)
        //{
        //    int nut = Random.Range(0, 3);
        //    if (nut < 2)
        //    {
                
        //        continue;
        //    }
        //    newnut3[i] = Instantiate(harmfulnutTemplate, this.transform);
        //    newnut3[i].transform.position = new Vector3(xPosition, 6.8f, 0);
        //    xPosition += 1.5f;
        //    if (i == 2)
        //    {
        //        xPosition += 1.5f;
        //    }
        //}
        preHole = 3;
        stageRender = true;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1.3 && stageCount < 28)
        {
            timer = 0;
            stageCount += 1;
            int hole = Random.Range(0, 5);
            if (hole == preHole)
            {
                hole = (hole + 1) % 5;
            }
            preHole = hole;
            float xPosition = -3.75f;
            GameObject[] newnut = new GameObject[2];
            for (int i = 0; i < 2; i++) {
                int nut = Random.Range(0, 3);
                if (nut < 2)
                {

                    continue;
                }
                //if (i == hole)
                //{
                //    xPosition += 3f;
                //}
                //else
                //{
                xPosition += 3.0f;
                //}
                newnut[i] = Instantiate(harmfulnutTemplate, this.transform);
                newnut[i].transform.position = new Vector3(xPosition, 6.8f, 0);
            }

        }

        else if (stageCount >= 28 && stageRender)
        {
            stageRender = false;
            goalObject.SetActive(true);
            goalObject.transform.position += new Vector3(0, 1.5f, 0);
        }

        if(!stageRender)
        {
            goalObject.transform.position += new Vector3(0, -2, 0) * Time.deltaTime;
        }


        this.transform.position += new Vector3(0, -2, 0) * Time.deltaTime;
        
    }
    
}
