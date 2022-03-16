using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroVideo : MonoBehaviour
{
    public GameObject canvas;
    public int timeDestroy;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(canvas, timeDestroy);
    }

}
