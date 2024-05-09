using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melon : MonoBehaviour, CollectibleItemInterface
{
    [SerializeField] private int melonValue;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Collect();
        }
    }
    public void Collect()
    {
        ItemController.instance.AddScore(melonValue);
        Destroy(gameObject);
    }

}
