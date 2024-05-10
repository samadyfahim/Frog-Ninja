using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IcePotion : MonoBehaviour, CollectibleItemInterface
{
    [SerializeField] private int icePotionFreezeTime;
    private AudioSource audioSource;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Collect();
        }
    }
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void Collect()
    {
        //audioSource.Play();
        FreezeSawMovement();
        Destroy(gameObject, audioSource.clip.length);
    }

    private void FreezeSawMovement()
    {
        GameObject sawObject = GameObject.FindWithTag("Saw");
        if (sawObject != null)
        {
            Saw saw = sawObject.GetComponent<Saw>();
            saw.FreezeMovement(icePotionFreezeTime);
        }
    }
}