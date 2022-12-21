using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class InstanceOptimizations : MonoBehaviour
{
    private Camera mainCamera;
    private void Start() {
        mainCamera = Camera.main;
    }
    // Update is called once per frame
    void Update()
    {
        var forwardDirection = gameObject.transform.forward;
        var perpendicularForward = Vector2.Perpendicular(new Vector2(forwardDirection.x, forwardDirection.y));
        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
        var objectsToLoopThrough = allObjects.Where(o => o.gameObject.tag != "Player" && o.gameObject.tag != "Floor");
        foreach(var tempObject in objectsToLoopThrough)
        if (tempObject.activeSelf)
        {
            var viewPoint = mainCamera.WorldToViewportPoint(tempObject.transform.position);
            if (
                viewPoint.x > 0 &&
                viewPoint.y > 0 &&
                viewPoint.z > 0
            )
            {
                // is visible
            }
            else
            {
                tempObject.gameObject.SetActive(false);
            }
        }
    }
}
