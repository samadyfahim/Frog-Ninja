using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melon : MonoBehaviour, CollectibleItemInterface
{
    [SerializeField] private int melonValue;
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
        Debug.Log(audioSource.clip);
        ItemController.instance.AddScore(melonValue);
        audioSource.Play();
        Destroy(gameObject, audioSource.clip.length);
    }

}
