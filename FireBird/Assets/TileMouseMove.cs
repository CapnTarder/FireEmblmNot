using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMouseMove : MonoBehaviour
{
    Color normalColor;
    public Color highLightColor;
    // Start is called before the first frame update
    void Start()
    {
        normalColor = GetComponent<Renderer>().material.color;
    }


   





    // Update is called once per frame
    void Update()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if(GetComponent<Collider>().Raycast( ray, out hitInfo, Mathf.Infinity  ))
        {
            GetComponent<Renderer>().material.color = highLightColor;

        }
        else
        {
            GetComponent<Renderer>().material.color = normalColor;
        }











      //  for (int i = 0; i< Input.touchCount; i++)
       // {
      //      Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.touches[i].position);
      //          Debug.DrawLine(Vector3.zero, touchPosition, Color.red);
      //  }
    }
}
