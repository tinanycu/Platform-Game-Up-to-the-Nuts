using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platforminfo : MonoBehaviour
{
    float timer;
    int preHole;
    public GameObject platformTemplate;
    public GameObject harmfulNutTemplate;
    public GameObject harmfulFlowerTemplate;
    public GameObject goalObject;
    int stageCount = 0;
    public bool stageRender;
    public bool harmfulbool;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        transform.localScale = new Vector3(0.08f, 0.08f, 0.08f);
        timer = 0;
        float xPosition = -3f;
        GameObject[] newPlatform1 = new GameObject[5];
        for (int i = 0; i < 5; i++)
        {
            newPlatform1[i] = Instantiate(platformTemplate, this.transform);
            newPlatform1[i].transform.position = new Vector3(xPosition, -0.2f, 0);
            xPosition += 1.5f;
        }
        xPosition = -3f;
        GameObject[] newPlatform2 = new GameObject[4];
        for (int i = 0; i < 4; i++)
        {
            newPlatform2[i] = Instantiate(platformTemplate, this.transform);
            newPlatform2[i].transform.position = new Vector3(xPosition, 2.4f, 0);
            xPosition += 1.5f;
            if (i == 0)
            {
                xPosition += 1.5f;
            }
        }
        xPosition = -3f;
        GameObject[] newPlatform3 = new GameObject[4];
        for (int i = 0; i < 4; i++)
        {
            newPlatform3[i] = Instantiate(platformTemplate, this.transform);
            newPlatform3[i].transform.position = new Vector3(xPosition, 5f, 0);
            xPosition += 1.5f;
            if (i == 2)
            {
                xPosition += 1.5f;
            }
        }
        preHole = 3;
        stageRender = true;
        harmfulbool = false;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1.3 && stageCount < 28)//1.3 8
        {
            timer = 0;
            stageCount += 1;
            int hole = Random.Range(0, 5);
            
            if (hole == preHole)
            {
                hole = (hole + 1) % 5;
            }
            preHole = hole;
            float xPosition = -4.5f;
            GameObject[] newPlatform = new GameObject[4];
            GameObject[] newNut = new GameObject[4];
            GameObject[] newFlower = new GameObject[4];
            
            for (int i = 0; i < 4; i++) {
                int harmful = Random.Range(0, 7);
                if (i == hole)
                {
                    xPosition += 3f;
                }
                else
                {
                    xPosition += 1.5f;
                }
                newPlatform[i] = Instantiate(platformTemplate, this.transform);
                newPlatform[i].transform.position = new Vector3(xPosition, 5f, 0);

                Debug.Log(harmful);
                bool b;
                if (harmfulbool == true)
                {
                    b = true;
                    
                }
                else
                {
                    if (harmful == 0 && i < 3 && i != hole - 1 && stageCount < 27)
                    {
                        Debug.Log("harmfulNut");
                        Debug.Log(stageCount);
                        newNut[i] = Instantiate(harmfulNutTemplate, this.transform);
                        newNut[i].transform.position = new Vector3(xPosition + 0.75f, 7f, 0);
                        //harmfulbool = true;
                        b = false;
                    }
                    else if (harmful == 1 && i < 3 && i != hole - 1 && stageCount < 27)
                    {
                        Debug.Log("harmfulFlower");
                        Debug.Log(stageCount);
                        newFlower[i] = Instantiate(harmfulFlowerTemplate, this.transform);
                        newFlower[i].transform.position = new Vector3(xPosition + 0.75f, 7f, 0);
                        //harmfulbool = true;
                        b = false;
                    }
                    else
                    {
                        //harmfulbool = false;
                        b = true;
                    }
                    
                }
                if (b == true)
                {
                    harmfulbool = false;
                }
                else{
                    harmfulbool = true;
                }
                
                
                
            }
            

        }

        else if (stageCount >= 28 && stageRender)
        {
            Debug.Log("goal");
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
