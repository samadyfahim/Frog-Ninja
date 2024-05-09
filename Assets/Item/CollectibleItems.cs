using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CollectibleItems
{
    public static GameObject CreateCollectibleItem(CollectibleItemTypes.CollectibleItemType type, Vector2 position)
    {
        GameObject collectiblePrefab = null;

        switch (type)
        {
            case CollectibleItemTypes.CollectibleItemType.Apple:
                collectiblePrefab = Resources.Load<GameObject>("ApplePrefab");
                break;
            case CollectibleItemTypes.CollectibleItemType.Kiwi:
                collectiblePrefab = Resources.Load<GameObject>("KiwiPrefab");
                break;
            case CollectibleItemTypes.CollectibleItemType.Cherry:
                collectiblePrefab = Resources.Load<GameObject>("CherryPrefab");
                break;
            case CollectibleItemTypes.CollectibleItemType.Melon:
                collectiblePrefab = Resources.Load<GameObject>("MelonPrefab");
                break;
            default:
                Debug.LogError("Unknown collectible item type: " + type);
                break;
        }

        if (collectiblePrefab != null)
        {
            return GameObject.Instantiate(collectiblePrefab, position, Quaternion.identity);
        }
        else
        {
            return null;
        }
    }
}
