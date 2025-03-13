using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetsAllRotations : MonoBehaviour
{
    float yRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yRotation += Time.deltaTime * 200;
        transform.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
