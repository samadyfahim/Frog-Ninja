using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kiwi : MonoBehaviour, CollectibleItemInterface
{
    [SerializeField] private int kiwiValue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Collect();
        }
    }
    public void Collect()
    {
        ItemController.instance.AddScore(kiwiValue);
        Destroy(gameObject);
    }
}

