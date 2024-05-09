using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Apple : MonoBehaviour, CollectibleItemInterface
{
    [SerializeField] private int appleValue;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Collect();
        }
    }
    public void Collect()
    {
        ItemController.instance.AddScore(appleValue);
        Destroy(gameObject);
    }
}
