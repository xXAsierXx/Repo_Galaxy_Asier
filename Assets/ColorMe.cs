using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMe : MonoBehaviour
{
    public Color myColor = Color.blue;
    private Color lastColorUsed = Color.blue;
    MeshRenderer myMaterial;
    
    // Start is called before the first frame update
    void Start()
    {
        myMaterial = gameObject.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lastColorUsed != myColor)
        {
            myMaterial.material.color = myColor;
        }
        
    }
}
