using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camra : MonoBehaviour
{
    [SerializeField] private Transform player; 
    public Vector3 offset = new Vector3(0, 2, -10);

    void LateUpdate()
    {
        if (player != null)
        {
            transform.position = player.position + offset; 
        }
    }
}
