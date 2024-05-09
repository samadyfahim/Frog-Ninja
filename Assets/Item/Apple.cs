using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Apple : MonoBehaviour, CollectibleItemInterface
{
    [SerializeField] private int appleValue = 3;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Collect();
        }
    }
    public void Collect()
    {
        GameManager.instance.AddScore(appleValue);
        Destroy(gameObject);
    }
}
