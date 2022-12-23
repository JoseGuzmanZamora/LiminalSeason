using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StockingSpawner : MonoBehaviour
{
    public GameObject stockingPrefab;
    public HouseDetailsManager detailsManager;
    public bool initialized = false;

    void Initialize()
    {
        if (Random.value >= 0.5f && detailsManager.isDecorated && detailsManager.isOffBounds is false)
        {
            Instantiate(stockingPrefab, transform.position, Quaternion.identity);
        }
        initialized = true;
    }

    private void Update() {
        if (initialized is false && detailsManager.isReady) Initialize();
    }
}
