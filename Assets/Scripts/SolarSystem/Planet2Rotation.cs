using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet2Rotation : MonoBehaviour
{
    float yPositionRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yPositionRotation += Time.deltaTime * 15;
        transform.rotation = Quaternion.Euler(0, yPositionRotation, 0);
    }
}
