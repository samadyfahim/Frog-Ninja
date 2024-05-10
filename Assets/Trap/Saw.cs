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
    private bool isFrozen;
    private float freezeTimer;

    private void Awake()
    {
        right = transform.position.x + moveDistance;
        left = transform.position.x - moveDistance; 
    }
    void Start()
    {
        
    }

    private void Update()
    {
        if (!isFrozen)
        {
            sawMovement();
        }
        else
        {
            if (freezeTimer > 0)
            {
                freezeTimer -= Time.deltaTime;
            }
            else
            {
                isFrozen = false;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerHealth>().Die();

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

    public void FreezeMovement(float duration)
    {
        isFrozen = true;
        freezeTimer = duration;
    }
}
