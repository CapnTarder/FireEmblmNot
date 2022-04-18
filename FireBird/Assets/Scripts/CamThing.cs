using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamThing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        if(PauseMenu.paused)
        {
            return;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (PauseMenu.paused)
        {
            return;
        }
    }
}
