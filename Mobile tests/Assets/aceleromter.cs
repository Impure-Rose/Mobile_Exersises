using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aceleromter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.acceleration.x / 10, 0, -Input.acceleration.z / 10);
    }
}
