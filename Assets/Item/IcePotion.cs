using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IcePotion : MonoBehaviour, CollectibleItemInterface
{
    [SerializeField] private int icePotionFreezeTime;
    private AudioSource audioSource;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
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
            if (saw != null)
            {
                saw.FreezeMovement(icePotionFreezeTime);
            }
        }
        else
        {
            Debug.LogWarning("No Saw object found in the scene.");
        }

    }
}