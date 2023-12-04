using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Controls : MonoBehaviour
{
    [SerializeField]
    float rychlost;

    float pohyb;

    float couvani = 1;

    GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            pohyb = -1;
        }
        else if(Input.GetKey(KeyCode.S))
        {
            pohyb = 1;
        }
        else
        {
            pohyb=0;
        }

        transform.Translate(pohyb * rychlost * Time.deltaTime, 0, 0);

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //var comp = collision.gameObject.GetComponent<Collider>();
        player.transform.Translate(couvani, 0, 0);
        player.transform.Rotate(0, 90, 0);
        Debug.Log("JJ");
    }
}
