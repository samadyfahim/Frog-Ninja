using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camra : MonoBehaviour
{
    [SerializeField] private Transform player; 
    public Vector3 offset = new Vector3(0, 2, -10);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LateUpdate()
    {
        if (player != null)
        {
            transform.position = player.position + offset;  // Set camera position based on player's position and offset
        }
    }
}
