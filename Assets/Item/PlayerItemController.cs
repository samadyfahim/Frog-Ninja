using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItemController : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Collectible"))
        {
            CollectibleItem collectibleItem = other.GetComponent<CollectibleItem>();
            if (collectibleItem != null)
            {
                collectibleItem.Collect();
                Destroy(other.gameObject);
            }
        }
    }
}
