using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Position : MonoBehaviour
{

    public GameObject trackedObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            LogTrackedObjectPosition();
        }
        
    }

    public void LogTrackedObjectPosition()
    {
       
            Debug.Log("La posicion de este " + trackedObject.name +
                        " es X:" + trackedObject.GetComponent<Transform>().position.x +
                        " / Y: " + trackedObject.GetComponent<Transform>().position.y +
                        "/ Z: " + trackedObject.GetComponent<Transform>().position.z);
        
        
    }

    
}
