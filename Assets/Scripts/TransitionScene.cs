using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToMainScene()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToEndScene()
    {
        SceneManager.LoadScene(2);
    }
}
