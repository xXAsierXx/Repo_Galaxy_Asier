using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon1Rotator : MonoBehaviour
{
    float yPositionRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yPositionRotation += Time.deltaTime * 100;
        transform.rotation = Quaternion.Euler(0, yPositionRotation, 0);
    }
}
