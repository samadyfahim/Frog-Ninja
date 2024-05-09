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
                collectiblePrefab = Resources.Load<GameObject>("Apple");
                break;
            case CollectibleItemTypes.CollectibleItemType.Kiwi:
                collectiblePrefab = Resources.Load<GameObject>("Kiwi");
                break;
            case CollectibleItemTypes.CollectibleItemType.Cherry:
                collectiblePrefab = Resources.Load<GameObject>("Cherry");
                break;
            case CollectibleItemTypes.CollectibleItemType.Melon:
                collectiblePrefab = Resources.Load<GameObject>("Melon");
                break;
            default:
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
