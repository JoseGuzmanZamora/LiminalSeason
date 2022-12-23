using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecollectionManager : MonoBehaviour
{
    public int amountCollected = 0;
    public TextMeshProUGUI text;
    public ErrorMessageController errorMessage;

    // Update is called once per frame
    void Update()
    {
        if (amountCollected >= 12)
        {
            // Game over you won
        }
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Stocking")
        {
            Destroy(other.gameObject);
            amountCollected++;
            text.text = $"Stockings: {amountCollected.ToString()}/12";
        }
        else if (other.gameObject.tag == "Finish")
        {
            errorMessage.gameObject.SetActive(true);
            errorMessage.counter = 0;
            var errorText = errorMessage.gameObject.GetComponent<TextMeshProUGUI>();
            errorText.text = "Sorry, this is off limits.";
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "RecollectionCenter")
        {
            if (amountCollected < 12)
            {
                errorMessage.gameObject.SetActive(true);
                errorMessage.counter = 0;
                var errorText = errorMessage.gameObject.GetComponent<TextMeshProUGUI>();
                errorText.text = "Collect all stockings before delivering.";
            }
            else
            {
                // game over you won
                SceneManager.LoadScene(2);
            }
        }
    }
}
