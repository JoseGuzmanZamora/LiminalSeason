using UnityEngine;

public class ErrorMessageController : MonoBehaviour
{
    public float countLimit = 3f;
    public float counter = 0f;

    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (counter < countLimit)
        {
            counter += Time.deltaTime;
            if (counter >= countLimit)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
