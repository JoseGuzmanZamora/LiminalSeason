using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseDetailsManager : MonoBehaviour
{
    public GameObject decorations;
    public bool isDecorated = false;

    private void Start() {
        isDecorated = Random.value >= 0.5f;
        if (isDecorated is false) decorations.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
