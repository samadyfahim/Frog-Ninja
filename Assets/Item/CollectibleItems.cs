using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CollectibleItems
{
    public static GameObject CreateCollectibleItem(CollectibleItemTypes type, Vector2 position)
    {
        GameObject collectiblePrefab = null;

        switch (type)
        {
            case CollectibleItemTypes.Coin:
                collectiblePrefab = Resources.Load<GameObject>("CoinPrefab");
                break;
            case CollectibleItemTypes.Gem:
                collectiblePrefab = Resources.Load<GameObject>("GemPrefab"); 
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
