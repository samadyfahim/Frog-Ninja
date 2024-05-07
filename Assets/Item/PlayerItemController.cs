using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItemController : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Collectible"))
        {
            ICollectibleItem collectibleItem = other.GetComponent<ICollectibleItem>();
            if (collectibleItem != null)
            {
                collectibleItem.Collect();
                Destroy(other.gameObject);
            }
        }
    }
}
