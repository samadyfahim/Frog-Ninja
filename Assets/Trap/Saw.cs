using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
{

    [SerializeField] float speed;
    public float moveDistance;
    private bool moveRight;
    private float right;
    private float left;

    private void Awake()
    {
        right = transform.position.x + moveDistance;
        left = transform.position.x - moveDistance; 
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sawMovement();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
           other.GetComponent<PlayerHealth>().Die();
           Debug.Log("Player died");

        }
        
    }

    private void sawMovement()
    {
        if (moveRight)
        {
            if(transform.position.x > left)
            {
                transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
            }
            else
            {
                moveRight = false;
            }
            
        }
        else
        {
            if (transform.position.x < right)
            {
                transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);

            }
            else
            {
                moveRight = true;
            }
        }
    }
}
