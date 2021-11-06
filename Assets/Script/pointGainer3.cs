using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointGainer3 : MonoBehaviour
{
    public float points = 0f;
    public Text textpointer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pointers()
    {
        points += 1f;
        textpointer.text = points.ToString("0");
    }
}
