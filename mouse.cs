using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mouse : MonoBehaviour
{
    float X;
    float Y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.mousePosition.x.ToString());
    }
    public void BeginDrag()
    {
        X = transform.position.x - Input.mousePosition.x;
        Y = transform.position.y - Input.mousePosition.y;
        

    }
    public void OnDrag()
    {
        transform.position = new Vector3(Input.mousePosition.x + X, Input.mousePosition.y + Y);
    }
}
