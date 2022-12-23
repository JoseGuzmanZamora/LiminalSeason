using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseDetailsManager : MonoBehaviour
{
    public GameObject decorations;
    public bool isDecorated = false;
    public bool isSpecial = false;
    public bool isReady = false;
    public bool isOffBounds = false;

    private void Start() {
        if (isSpecial is false) isDecorated = Random.value >= 0.5f;
        if (isDecorated is false) decorations.SetActive(false);
        isReady = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
