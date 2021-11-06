using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] GameObject protecc;
    [SerializeField] GameObject protecc2;
    [SerializeField] Transform player;
    [SerializeField] float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        protecc.SetActive(true);
        protecc2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            protecc.SetActive(false);
            protecc2.SetActive(false);
        }
        
       if (Input.GetKey(KeyCode.E))
        {
            protecc.SetActive(true);
            protecc2.SetActive(true);
        }

        float xDirection = Input.GetAxis("Horizontal");

        Vector3 moveDirection = new Vector3(xDirection, 0.0f, 0.0f);

        player.position += moveDirection * speed;
    }
}
