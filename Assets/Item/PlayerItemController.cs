using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItemController : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Collectible"))
        {
            CollectibleItemInterface collectibleItem = other.GetComponent<CollectibleItemInterface>();
            if (collectibleItem != null)
            {
                collectibleItem.Collect();
                Destroy(other.gameObject);
            }
        }
    }
}
