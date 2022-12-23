using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecollectionManager : MonoBehaviour
{
    public int amountCollected = 0;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Stocking")
        {
            Destroy(other.gameObject);
            amountCollected++;
        }
    }
}
