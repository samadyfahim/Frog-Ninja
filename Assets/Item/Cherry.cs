using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cherry : MonoBehaviour, CollectibleItemInterface
{
    [SerializeField] private int charryValue;
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
        ItemController.instance.AddScore(charryValue);
        audioSource.Play();
        Destroy(gameObject, audioSource.clip.length);
    }
}
