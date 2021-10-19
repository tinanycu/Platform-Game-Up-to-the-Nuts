using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leafinfo : MonoBehaviour
{
    float timer;
    int preHole;
    //public GameObject nutTemplate;
    public GameObject goalObject;
    int stageCount = 0;
    public bool stageRender;
    public GameObject leafTemplate1_1;
    public GameObject leafTemplate1_2;
    public GameObject leafTemplate2_1;
    public GameObject leafTemplate2_2;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(0.08f, 0.08f, 0.08f);
        timer = 0;
        float xPosition = -3f;
        //GameObject[] newnut1 = new GameObject[5];

        //for (int i = 0; i < 5; i++)
        //{
        //    newnut1[i] = Instantiate(nutTemplate, this.transform);
        //    newnut1[i].transform.position = new Vector3(xPosition, 0.4f, 0);
        //    xPosition += 1.5f;
        //}
        //xPosition = -3f;
        //GameObject[] newnut2 = new GameObject[4];

        //for (int i = 0; i < 4; i++)
        //{
        //    int nut = Random.Range(0, 3);
        //    if (nut < 2)
        //    {

        //        continue;
        //    }
        //    newnut2[i] = Instantiate(nutTemplate, this.transform);
        //    newnut2[i].transform.position = new Vector3(xPosition, 3.0f, 0);
        //    xPosition += 1.5f;
        //    //if (i == 0)
        //    //{
        //    //    xPosition += 1.5f;
        //    //}
        //}

        //xPosition = -3f;
        //GameObject[] newnut3 = new GameObject[4];
        //for (int i = 0; i < 4; i++)
        //{
        //    int nut = Random.Range(0, 3);
        //    if (nut < 2)
        //    {

        //        continue;
        //    }
        //    newnut3[i] = Instantiate(nutTemplate, this.transform);
        //    newnut3[i].transform.position = new Vector3(xPosition, 5.6f, 0);
        //    xPosition += 1.5f;
        //    if (i == 2)
        //    {
        //        xPosition += 1.5f;
        //    }
        //}
        //preHole = 3;
        stageRender = true;
        xPosition = -2f;
        GameObject[] newleaf = new GameObject[6];
        for (int i = 0; i < 6; i++)
        {
            if (Random.Range(0, 7) < 6)
            {
                xPosition += 2f;
                continue;
            }
            newleaf[i] = Instantiate(leafTemplate1_1, this.transform);
            newleaf[i].transform.position = new Vector3(xPosition + 0.2f * Random.Range(-4, 5), 1f + 0.5f * Random.Range(6, 12), 0);
            xPosition += 2f;
        }
        xPosition = -2f;
        GameObject[] newleaf2 = new GameObject[6];
        for (int i = 0; i < 6; i++)
        {
            if (Random.Range(0, 7) < 6)
            {
                xPosition += 2f;
                continue;
            }
            newleaf2[i] = Instantiate(leafTemplate1_2, this.transform);
            newleaf2[i].transform.position = new Vector3(xPosition + 0.2f * Random.Range(-4, 5), 1f + 0.5f * Random.Range(6, 12), 0);
            xPosition += 2f;
        }
        xPosition = -2f;
        GameObject[] newleaf3 = new GameObject[6];
        for (int i = 0; i < 6; i++)
        {
            if (Random.Range(0, 7) < 6)
            {
                xPosition += 2f;
                continue;
            }
            newleaf3[i] = Instantiate(leafTemplate2_1, this.transform);
            newleaf3[i].transform.position = new Vector3(xPosition + 0.2f * Random.Range(-4, 5), 1f + 0.5f * Random.Range(6, 12), 0);
            xPosition += 2f;
        }
        xPosition = -2f;
        GameObject[] newleaf4 = new GameObject[6];
        for (int i = 0; i < 6; i++)
        {
            if (Random.Range(0, 7) < 6)
            {
                xPosition += 2f;
                continue;
            }
            newleaf4[i] = Instantiate(leafTemplate2_2, this.transform);
            newleaf4[i].transform.position = new Vector3(xPosition + 0.2f * Random.Range(-4, 5), 1f + 0.5f * Random.Range(6, 12), 0);
            xPosition += 2f;
        }
        xPosition = -2f;
        GameObject[] newleaf5 = new GameObject[6];
        for (int i = 0; i < 6; i++)
        {
            if (Random.Range(0, 7) < 6)
            {
                xPosition += 2f;
                continue;
            }
            newleaf5[i] = Instantiate(leafTemplate1_1, this.transform);
            newleaf5[i].transform.position = new Vector3(xPosition + 0.2f * Random.Range(-4, 5), 1.5f + 0.5f * Random.Range(6, 12), 0);
            xPosition += 2f;
        }
        xPosition = -2f;
        GameObject[] newleaf6 = new GameObject[6];
        for (int i = 0; i < 6; i++)
        {
            if (Random.Range(0, 7) < 6)
            {
                xPosition += 2f;
                continue;
            }
            newleaf6[i] = Instantiate(leafTemplate1_2, this.transform);
            newleaf6[i].transform.position = new Vector3(xPosition + 0.2f * Random.Range(-4, 5), 1.5f + 0.5f * Random.Range(6, 12), 0);
            xPosition += 2f;
        }
        xPosition = -2f;
        GameObject[] newleaf7 = new GameObject[6];
        for (int i = 0; i < 6; i++)
        {
            if (Random.Range(0, 7) < 6)
            {
                xPosition += 2f;
                continue;
            }
            newleaf7[i] = Instantiate(leafTemplate2_1, this.transform);
            newleaf7[i].transform.position = new Vector3(xPosition + 0.2f * Random.Range(-4, 5), 1.5f + 0.5f * Random.Range(6, 12), 0);
            xPosition += 2f;
        }
        xPosition = -2f;
        GameObject[] newleaf8 = new GameObject[6];
        for (int i = 0; i < 6; i++)
        {
            if (Random.Range(0, 7) < 6)
            {
                xPosition += 2f;
                continue;
            }
            newleaf8[i] = Instantiate(leafTemplate2_2, this.transform);
            newleaf8[i].transform.position = new Vector3(xPosition + 0.2f * Random.Range(-4, 5), 1.5f + 0.5f * Random.Range(6, 12), 0);
            xPosition += 2f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1.3 && stageCount < 27)
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
            //GameObject[] newnut = new GameObject[5];
            //for (int i = 0; i < 5; i++) {
            //    int nut = Random.Range(0, 3);
            //    if (nut < 2)
            //    {

            //        continue;
            //    }
            //    //Debug.Log(i);
            //    //if (i == hole)
            //    //{
            //    //    xPosition += 3f;
            //    //}
            //    //else
            //    //{
            //    xPosition += 1.5f;
            //    //}
            //    newnut[i] = Instantiate(nutTemplate, this.transform);
            //    newnut[i].transform.position = new Vector3(xPosition, 5.6f, 0);
            //}
            xPosition = -2f;
            GameObject[] newleaf = new GameObject[6];
            for (int i = 0; i < 6; i++)
            {
                if (Random.Range(0, 7) < 6)
                {
                    xPosition += 2f;
                    continue;
                }
                newleaf[i] = Instantiate(leafTemplate1_1, this.transform);
                newleaf[i].transform.position = new Vector3(xPosition+ 0.2f*Random.Range(-4, 5), 5.6f+0.1f*Random.Range(6,12), 0);
                xPosition += 2f;
            }
            xPosition = -2f;
            GameObject[] newleaf2 = new GameObject[6];
            for (int i = 0; i < 6; i++)
            {
                if (Random.Range(0, 7) < 6)
                {
                    xPosition += 2f;
                    continue;
                }
                newleaf2[i] = Instantiate(leafTemplate1_2, this.transform);
                newleaf2[i].transform.position = new Vector3(xPosition + 0.2f * Random.Range(-4, 5), 5.6f + 0.1f * Random.Range(6, 12), 0);
                xPosition += 2f;
            }
            xPosition = -2f;
            GameObject[] newleaf3 = new GameObject[6];
            for (int i = 0; i < 6; i++)
            {
                if (Random.Range(0, 7) < 6)
                {
                    xPosition += 2f;
                    continue;
                }
                newleaf3[i] = Instantiate(leafTemplate2_1, this.transform);
                newleaf3[i].transform.position = new Vector3(xPosition + 0.2f * Random.Range(-4, 5), 5.6f + 0.1f * Random.Range(6, 12), 0);
                xPosition += 2f;
            }
            xPosition = -2f;
            GameObject[] newleaf4 = new GameObject[6];
            for (int i = 0; i < 6; i++)
            {
                if (Random.Range(0, 7) < 6)
                {
                    xPosition += 2f;
                    continue;
                }
                newleaf4[i] = Instantiate(leafTemplate2_2, this.transform);
                newleaf4[i].transform.position = new Vector3(xPosition + 0.2f * Random.Range(-4, 5), 5.6f + 0.1f * Random.Range(6, 12), 0);
                xPosition += 2f;
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
