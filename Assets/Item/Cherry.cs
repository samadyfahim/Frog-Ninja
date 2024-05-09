using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cherry : MonoBehaviour, CollectibleItemInterface
{
    [SerializeField] private int charryValue;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Collect();
        }
    }
    public void Collect()
    {
        ItemController.instance.AddScore(charryValue);
        Destroy(gameObject);
    }
}
