using System;
using Unity.VisualScripting;
using UnityEngine;

public class ColorMe2 : MonoBehaviour
{
    private UnityEngine.Object[] myObjects; 
    
    public Color myColor = Color.blue;
    private Color lastColorUsed = Color.blue;
    MeshRenderer myMaterial;

    public bool findByTag;
    public String chosingTag;


    // Start is called before the first frame update
    void Start()
    {
        if (findByTag)
        {
            myObjects = GameObject.FindGameObjectsWithTag("Player");
        }
        else
        {
            myObjects = GameObject.FindObjectsOfType(typeof(MonoBehaviour));
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        if (myObjects != null)
        {
            foreach (var obj in myObjects)
            {
                if (obj.GetComponent<MeshRenderer>())
                {
                    obj.GetComponent<MeshRenderer>().material.color = myColor;
                }
               
            }

        }
        }
    }

