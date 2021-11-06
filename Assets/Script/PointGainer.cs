using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointGainer : MonoBehaviour
{
    public pointGainer3 pointsG;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Circle"))
        {
            Debug.Log("Touched");
            pointsG.Pointers();
        }
    }
}
