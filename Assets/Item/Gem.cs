using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour, CollectibleItem
{
    public int gemValue = 50;

    public void Collect()
    {
        GameManager.instance.AddScore(gemValue);
        Destroy(gameObject);
    }
}

