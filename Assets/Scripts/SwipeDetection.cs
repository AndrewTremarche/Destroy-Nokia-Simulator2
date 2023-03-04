using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeDetection : MonoBehaviour
{
    bool isFingerDown;
    private Vector2 startPos;
    private int swipeDistance = 10;
    private Touch touch;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!isFingerDown && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            startPos = Input.touches[0].position;
            isFingerDown = true;
        }

        if (isFingerDown)
        {
            if (Input.touches[0].position.x >= startPos.x + swipeDistance)
            {
                isFingerDown = false;
                Debug.Log("Swipe Right");
            }

            if (Input.touches[0].position.x <= startPos.x - swipeDistance)
            {
                isFingerDown = false;
                Debug.Log("Swipe Left");
            }
        }
        if (isFingerDown && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Ended)
        {
            isFingerDown = false;
        }
    }
}
