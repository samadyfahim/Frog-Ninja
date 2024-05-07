using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour, CollectibleItem
{
    public int coinValue = 10;

    public void Collect()
    {
        GameManager.instance.AddScore(coinValue);
        Destroy(gameObject);
    }
}
