using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChristmasSpiritCounter : MonoBehaviour
{
    public float spirit = 100;
    public int playMinutes = 5;
    private int playSeconds = 0;
    private float timeCounter = 0f;
    public Image progressBar;
    void Start()
    {
        playSeconds = playMinutes * 60;
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime;
        if (timeCounter >= playSeconds)
        {
            // game over
            SceneManager.LoadScene(3);
        }

        // Current value
        spirit = ((playSeconds - timeCounter) * 100) / playSeconds;
        var difference = 100 - spirit;
        progressBar.rectTransform.anchoredPosition = new Vector2(difference * -8, progressBar.rectTransform.anchoredPosition.y);
    }
}
