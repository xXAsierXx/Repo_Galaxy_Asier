using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movementsInput();
    }

    public void movementsInput()
    {
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(1, 0, 0);
        } else if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(-1, 0, 0);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(0, 1, 0);
        } else if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(0, -1 , 0);
        } else if (Input.GetKey(KeyCode.Q))
        {
            gameObject.transform.Translate(0, 0, -1);
        } else if (Input.GetKey(KeyCode.E))
        {
            gameObject.transform.Translate(0, 0, 1);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Rotate(0, 1, 0);
        } else if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Rotate(0, -1, 0);
        }

    }
}
