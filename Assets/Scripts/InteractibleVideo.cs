using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractibleVideo : MonoBehaviour
{
    public GameObject canvas;

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "TableTop")
        {
            canvas.SetActive(true);
            Debug.Log("cube off table");
        }
    }

    void OnCollisionEnter(Collision other)
    {
         if (other.gameObject.tag == "TableTop")
         {
            canvas.SetActive(false);
            Debug.Log("cube on table");
         }
    }


}
