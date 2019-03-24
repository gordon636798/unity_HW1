using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class star : MonoBehaviour
{
    
    public RawImage[] imgs = new RawImage[10];
    public Texture [] textures= new Texture[3];
    public Button inc;
    public Button dec;
    public Text txt;

    int cnt=-1;
    int maxStar = 10;
    float t = 0f;
    public string name;
    public bool change = true;
    // Start is called before the first frame update\
    void OnGUI()
    {
        GUI.enabled = change;
        name = GUI.TextField(new Rect(25, 50, 100, 30), name);
        GUI.enabled = true;



    }
    void Start()
    {
        txt.transform.localPosition = new Vector3(-525, 279,0);
        foreach (RawImage i in imgs)
        {
            i.texture = textures[0];
            i.enabled = false;

        }


    }
    public void incChange()
    {
        if(cnt + 1 < maxStar)
        {
            cnt++;
            int X = Random.Range(-450, 550); //550
            int Y = Random.Range(-300, 100); //160
            imgs[cnt].transform.position = new Vector3(640+ X, 358 + Y, 510);
            imgs[cnt].enabled = true;
        }

    }

    public void decChange()
    {
        if (cnt >= 0)
        {
            imgs[cnt].enabled = false;
            cnt--;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
            change = !change;
        if (change)
            txt.text = "開啟輸入";
        else
            txt.text = "關閉輸入";
        //GUI.enabled = change;
        if (t + 2f < Time.time)
        {
            t = Time.time;
            Trinkle();
        }


    }

    private void Trinkle()
    {
        foreach (RawImage i in imgs)
        {


            float scale = Random.Range(0.5f, 3.0f);

            i.transform.localScale =  new Vector3(scale,scale,scale);
            int R = Random.Range(0, 3);
            i.texture = textures[R];

        }
    }
}
