using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCollectible : MonoBehaviour
{
    public GameObject[] pickupPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(pickupPrefabs[Random.Range(0, pickupPrefabs.Length)], transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
